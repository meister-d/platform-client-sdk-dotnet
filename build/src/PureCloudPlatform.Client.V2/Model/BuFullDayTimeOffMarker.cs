using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuFullDayTimeOffMarker
    /// </summary>
    [DataContract]
    public partial class BuFullDayTimeOffMarker :  IEquatable<BuFullDayTimeOffMarker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuFullDayTimeOffMarker" /> class.
        /// </summary>
        /// <param name="BusinessUnitDate">The date of the time off marker, interpreted in the business unit's time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
        /// <param name="LengthMinutes">The length of the time off marker in minutes.</param>
        /// <param name="Description">The description of the time off marker.</param>
        /// <param name="ActivityCodeId">The ID of the activity code associated with the time off marker.</param>
        /// <param name="Paid">Whether the time off marker is paid.</param>
        /// <param name="PayableMinutes">Payable minutes for the time off marker.</param>
        /// <param name="TimeOffRequestId">The ID of the time off request.</param>
        /// <param name="TimeOffRequestSyncVersion">The sync version of the full day time off request for which the scheduled activity is associated.</param>
        /// <param name="Delete">Set to 'true' to delete this time off marker. Will always be null on responses, only has an effect on schedule update.</param>
        public BuFullDayTimeOffMarker(String BusinessUnitDate = null, int? LengthMinutes = null, string Description = null, string ActivityCodeId = null, bool? Paid = null, int? PayableMinutes = null, string TimeOffRequestId = null, int? TimeOffRequestSyncVersion = null, bool? Delete = null)
        {
            this.BusinessUnitDate = BusinessUnitDate;
            this.LengthMinutes = LengthMinutes;
            this.Description = Description;
            this.ActivityCodeId = ActivityCodeId;
            this.Paid = Paid;
            this.PayableMinutes = PayableMinutes;
            this.TimeOffRequestId = TimeOffRequestId;
            this.TimeOffRequestSyncVersion = TimeOffRequestSyncVersion;
            this.Delete = Delete;
            
        }
        


        /// <summary>
        /// The date of the time off marker, interpreted in the business unit's time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
        /// </summary>
        /// <value>The date of the time off marker, interpreted in the business unit's time zone. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
        [DataMember(Name="businessUnitDate", EmitDefaultValue=false)]
        public String BusinessUnitDate { get; set; }



        /// <summary>
        /// The length of the time off marker in minutes
        /// </summary>
        /// <value>The length of the time off marker in minutes</value>
        [DataMember(Name="lengthMinutes", EmitDefaultValue=false)]
        public int? LengthMinutes { get; set; }



        /// <summary>
        /// The description of the time off marker
        /// </summary>
        /// <value>The description of the time off marker</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The ID of the activity code associated with the time off marker
        /// </summary>
        /// <value>The ID of the activity code associated with the time off marker</value>
        [DataMember(Name="activityCodeId", EmitDefaultValue=false)]
        public string ActivityCodeId { get; set; }



        /// <summary>
        /// Whether the time off marker is paid
        /// </summary>
        /// <value>Whether the time off marker is paid</value>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }



        /// <summary>
        /// Payable minutes for the time off marker
        /// </summary>
        /// <value>Payable minutes for the time off marker</value>
        [DataMember(Name="payableMinutes", EmitDefaultValue=false)]
        public int? PayableMinutes { get; set; }



        /// <summary>
        /// The ID of the time off request
        /// </summary>
        /// <value>The ID of the time off request</value>
        [DataMember(Name="timeOffRequestId", EmitDefaultValue=false)]
        public string TimeOffRequestId { get; set; }



        /// <summary>
        /// The sync version of the full day time off request for which the scheduled activity is associated
        /// </summary>
        /// <value>The sync version of the full day time off request for which the scheduled activity is associated</value>
        [DataMember(Name="timeOffRequestSyncVersion", EmitDefaultValue=false)]
        public int? TimeOffRequestSyncVersion { get; set; }



        /// <summary>
        /// Set to 'true' to delete this time off marker. Will always be null on responses, only has an effect on schedule update
        /// </summary>
        /// <value>Set to 'true' to delete this time off marker. Will always be null on responses, only has an effect on schedule update</value>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuFullDayTimeOffMarker {\n");

            sb.Append("  BusinessUnitDate: ").Append(BusinessUnitDate).Append("\n");
            sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
            sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
            sb.Append("  TimeOffRequestSyncVersion: ").Append(TimeOffRequestSyncVersion).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BuFullDayTimeOffMarker);
        }

        /// <summary>
        /// Returns true if BuFullDayTimeOffMarker instances are equal
        /// </summary>
        /// <param name="other">Instance of BuFullDayTimeOffMarker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuFullDayTimeOffMarker other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.BusinessUnitDate == other.BusinessUnitDate ||
                    this.BusinessUnitDate != null &&
                    this.BusinessUnitDate.Equals(other.BusinessUnitDate)
                ) &&
                (
                    this.LengthMinutes == other.LengthMinutes ||
                    this.LengthMinutes != null &&
                    this.LengthMinutes.Equals(other.LengthMinutes)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ActivityCodeId == other.ActivityCodeId ||
                    this.ActivityCodeId != null &&
                    this.ActivityCodeId.Equals(other.ActivityCodeId)
                ) &&
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) &&
                (
                    this.PayableMinutes == other.PayableMinutes ||
                    this.PayableMinutes != null &&
                    this.PayableMinutes.Equals(other.PayableMinutes)
                ) &&
                (
                    this.TimeOffRequestId == other.TimeOffRequestId ||
                    this.TimeOffRequestId != null &&
                    this.TimeOffRequestId.Equals(other.TimeOffRequestId)
                ) &&
                (
                    this.TimeOffRequestSyncVersion == other.TimeOffRequestSyncVersion ||
                    this.TimeOffRequestSyncVersion != null &&
                    this.TimeOffRequestSyncVersion.Equals(other.TimeOffRequestSyncVersion)
                ) &&
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.BusinessUnitDate != null)
                    hash = hash * 59 + this.BusinessUnitDate.GetHashCode();

                if (this.LengthMinutes != null)
                    hash = hash * 59 + this.LengthMinutes.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ActivityCodeId != null)
                    hash = hash * 59 + this.ActivityCodeId.GetHashCode();

                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();

                if (this.PayableMinutes != null)
                    hash = hash * 59 + this.PayableMinutes.GetHashCode();

                if (this.TimeOffRequestId != null)
                    hash = hash * 59 + this.TimeOffRequestId.GetHashCode();

                if (this.TimeOffRequestSyncVersion != null)
                    hash = hash * 59 + this.TimeOffRequestSyncVersion.GetHashCode();

                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();

                return hash;
            }
        }
    }

}
