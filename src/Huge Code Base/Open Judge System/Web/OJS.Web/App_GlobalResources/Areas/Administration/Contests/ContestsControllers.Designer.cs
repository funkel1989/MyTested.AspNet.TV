﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Areas.Administration.Contests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ContestsControllers {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ContestsControllers() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OJS.Web.App_GlobalResources.Areas.Administration.Contests.ContestsControllers", typeof(ContestsControllers).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest is active and Duration and Type cannot be edited!.
        /// </summary>
        public static string Active_contest_cannot_edit_duration_type {
            get {
                return ResourceManager.GetString("Active_contest_cannot_edit_duration_type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest is active and cannot be deleted!.
        /// </summary>
        public static string Active_contest_forbidden_for_deletion {
            get {
                return ResourceManager.GetString("Active_contest_forbidden_for_deletion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest is active and participants cannot be transferred.
        /// </summary>
        public static string Active_contest_forbidden_for_transfer {
            get {
                return ResourceManager.GetString("Active_contest_forbidden_for_transfer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully added {0} minutes to the times of all selected active participants in the contest {1}.
        /// </summary>
        public static string Added_time_to_participants_online {
            get {
                return ResourceManager.GetString("Added_time_to_participants_online", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully added {0} minutes to the time of the participant with username: {1}, in the contest {2}.
        /// </summary>
        public static string Added_time_to_single_participant_online {
            get {
                return ResourceManager.GetString("Added_time_to_single_participant_online", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest added successfully.
        /// </summary>
        public static string Contest_added {
            get {
                return ResourceManager.GetString("Contest_added", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest edited successfully.
        /// </summary>
        public static string Contest_edited {
            get {
                return ResourceManager.GetString("Contest_edited", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest not found.
        /// </summary>
        public static string Contest_not_found {
            get {
                return ResourceManager.GetString("Contest_not_found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest is not valid.
        /// </summary>
        public static string Contest_not_valid {
            get {
                return ResourceManager.GetString("Contest_not_valid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contest start date must be before the contest end date.
        /// </summary>
        public static string Contest_start_date_before_end {
            get {
                return ResourceManager.GetString("Contest_start_date_before_end", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duration must be in format &quot;hh:mm&quot;.
        /// </summary>
        public static string Duration_invalid_format {
            get {
                return ResourceManager.GetString("Duration_invalid_format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;br /&gt;WARNING: The following users&apos; contest duration was not updated because their contest duration would have been reduced below the base contest duration: {0}.
        /// </summary>
        public static string Failed_to_update_participants_duration {
            get {
                return ResourceManager.GetString("Failed_to_update_participants_duration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No active contests.
        /// </summary>
        public static string No_active_contests {
            get {
                return ResourceManager.GetString("No_active_contests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No future contests.
        /// </summary>
        public static string No_future_contests {
            get {
                return ResourceManager.GetString("No_future_contests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No latest contests.
        /// </summary>
        public static string No_latest_contests {
            get {
                return ResourceManager.GetString("No_latest_contests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Question could not be found by given Id.
        /// </summary>
        public static string No_question_by_id {
            get {
                return ResourceManager.GetString("No_question_by_id", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The participant is not in the contest!.
        /// </summary>
        public static string Participant_not_in_contest {
            get {
                return ResourceManager.GetString("Participant_not_in_contest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Participants transferred successfully.
        /// </summary>
        public static string Participants_transferred {
            get {
                return ResourceManager.GetString("Participants_transferred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Practice start date must be before the practice end date.
        /// </summary>
        public static string Practice_start_date_before_end {
            get {
                return ResourceManager.GetString("Practice_start_date_before_end", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Problem groups count cannot be more than {0}.
        /// </summary>
        public static string Problem_groups_count_limit {
            get {
                return ResourceManager.GetString("Problem_groups_count_limit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1} submissions for {0}.zip.
        /// </summary>
        public static string Report_zip_format {
            get {
                return ResourceManager.GetString("Report_zip_format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field is required for Online Contest.
        /// </summary>
        public static string Required_field_for_online {
            get {
                return ResourceManager.GetString("Required_field_for_online", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose at least one submission type!.
        /// </summary>
        public static string Select_one_submission_type {
            get {
                return ResourceManager.GetString("Select_one_submission_type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully subtracted {0} minutes from the times of all selected active participants in the contest {1}.
        /// </summary>
        public static string Subtracted_time_from_participants_online {
            get {
                return ResourceManager.GetString("Subtracted_time_from_participants_online", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully subtracted {0} minutes from the time of the participant with username: {1}, in the contest {2}.
        /// </summary>
        public static string Subtracted_time_from_single_participant_online {
            get {
                return ResourceManager.GetString("Subtracted_time_from_single_participant_online", resourceCulture);
            }
        }
    }
}