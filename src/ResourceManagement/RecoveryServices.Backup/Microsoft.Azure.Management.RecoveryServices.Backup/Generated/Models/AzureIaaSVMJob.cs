// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Azure IaaS VM workload-specifc job object.
    /// </summary>
    public partial class AzureIaaSVMJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJob class.
        /// </summary>
        public AzureIaaSVMJob() { }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMJob class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        /// <param name="duration">Time elapsed during the execution of this
        /// job.</param>
        /// <param name="actionsInfo">Gets or sets the state/actions
        /// applicable on this job like cancel/retry.</param>
        /// <param name="errorDetails">Error details on execution of this
        /// job.</param>
        /// <param name="virtualMachineVersion">Specifies whether the backup
        /// item is a Classic or an Azure Resource Manager VM.</param>
        /// <param name="extendedInfo">Additional information for this
        /// job.</param>
        public AzureIaaSVMJob(string entityFriendlyName = default(string), BackupManagementType? backupManagementType = default(BackupManagementType?), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), System.Collections.Generic.IList<JobSupportedAction?> actionsInfo = default(System.Collections.Generic.IList<JobSupportedAction?>), System.Collections.Generic.IList<AzureIaaSVMErrorInfo> errorDetails = default(System.Collections.Generic.IList<AzureIaaSVMErrorInfo>), string virtualMachineVersion = default(string), AzureIaaSVMJobExtendedInfo extendedInfo = default(AzureIaaSVMJobExtendedInfo))
            : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            Duration = duration;
            ActionsInfo = actionsInfo;
            ErrorDetails = errorDetails;
            VirtualMachineVersion = virtualMachineVersion;
            ExtendedInfo = extendedInfo;
        }

        /// <summary>
        /// Gets or sets time elapsed during the execution of this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the state/actions applicable on this job like
        /// cancel/retry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionsInfo")]
        public System.Collections.Generic.IList<JobSupportedAction?> ActionsInfo { get; set; }

        /// <summary>
        /// Gets or sets error details on execution of this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "errorDetails")]
        public System.Collections.Generic.IList<AzureIaaSVMErrorInfo> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the backup item is a Classic or an
        /// Azure Resource Manager VM.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualMachineVersion")]
        public string VirtualMachineVersion { get; set; }

        /// <summary>
        /// Gets or sets additional information for this job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extendedInfo")]
        public AzureIaaSVMJobExtendedInfo ExtendedInfo { get; set; }

    }
}