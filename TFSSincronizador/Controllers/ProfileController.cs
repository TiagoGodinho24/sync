using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TFSSincronizador.Context;
using TFSSincronizador.Models;
using TFSSincronizador.Repositories.Interfaces;

namespace TFSSincronizador.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IProfileRepository _profileRepository;

        public ProfileController(AppDbContext context, IProfileRepository profileRepository)
        {
            _context = context;
            _profileRepository = profileRepository;
        }

        public IActionResult List()
        {
            var profiles = _profileRepository.Profiles;
            return View(profiles);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var profiles = _profileRepository.Profiles;
            return View();
        }

        [HttpGet]
        public IActionResult EditMapping()
        {
            var profiles = _profileRepository.Profiles;
            return View();
        }

        public IActionResult Types()
        {
            return View();
        }

        public IActionResult StatesStatuses()
        {
            return View();
        }

        public IActionResult Fields()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id) 
        {
            var profiles = _profileRepository.Profiles;
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Profile profile)
        {
            if (ModelState.IsValid)
            {
                var newProfile = new Profile
                {
                    ProfileName = profile.ProfileName,
                    Status = profile.Status,
                    SyncDirection = profile.SyncDirection,
                    JProject = profile.JProject,
                    TFSCollection = profile.TFSCollection,
                    TFSProject = profile.TFSProject
                };

                _context.Profiles.Add(newProfile);
                _context.SaveChanges();

                //profile.ProfileId = newProfile.ProfileId;


                TempData["ProfileId"] = newProfile.ProfileId;
                return RedirectToAction("CreateConfiguration");

            }
            else
            {
                return View();
            }
        }

            [HttpGet]
            public IActionResult CreateConfiguration() 
            {
                var profileId = TempData["ProfileId"] as int?;

                if (profileId.HasValue)
                {
                    ViewData["ProfileId"]=profileId;
                    return View();
                }
                else
                {
                    return RedirectToAction("Create");
                } 
            }

            [HttpPost]
            public IActionResult CreateConfiguration(ProfileConfiguration profileConfiguration)
            {
            
                if (ModelState.IsValid)
                {
                    var profileId = ViewData["ProfileId"] as int?;
                    
                    if (profileId.HasValue)
                    {

                        var newprofileConfig = new ProfileConfiguration
                        {
                            JiraURL = profileConfiguration.JiraURL,
                            Email = profileConfiguration.Email,
                            APIToken = profileConfiguration.APIToken,
                            Project = profileConfiguration.Project,
                            CustomField = profileConfiguration.CustomField,
                            TFSUrl = profileConfiguration.TFSUrl,
                            Name = profileConfiguration.Name,
                            PassWord = profileConfiguration.PassWord,
                            Domain = profileConfiguration.Domain,
                            Collection = profileConfiguration.Collection,
                            TFSProject = profileConfiguration.TFSProject,
                            TFSCustom = profileConfiguration.TFSCustom,

                            MappingFieldProfile = profileId.Value
                        };


                        _context.ProfileConfig.Add(newprofileConfig);
                        _context.SaveChanges();

                        return RedirectToAction("CreateStatus");
                    }
                    else
                    {
                        return View("Create");
                    }
                }
                else
                {
                    return View();
                }
            }

        public IActionResult CreateFields()
        {
            return View();
        }

        public IActionResult CreateTypes()
        {
            return View();
        }

        public IActionResult CreateStatus()
        {
            return View();
        }
    }
}
