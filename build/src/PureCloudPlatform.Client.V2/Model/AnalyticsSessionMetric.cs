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
    /// AnalyticsSessionMetric
    /// </summary>
    [DataContract]
    public partial class AnalyticsSessionMetric :  IEquatable<AnalyticsSessionMetric>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSessionMetric" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnalyticsSessionMetric() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSessionMetric" /> class.
        /// </summary>
        
        
        /// <param name="Name">Unique name of this metric (required).</param>
        
        
        
        /// <param name="Value">The metric value (required).</param>
        
        
        
        /// <param name="EmitDate">Metric emission date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        
        
        public AnalyticsSessionMetric(string Name = null, long? Value = null, DateTime? EmitDate = null)
        {
            
            
            
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for AnalyticsSessionMetric and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            
            
            
            
            
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for AnalyticsSessionMetric and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            
            
            
            
            
            // to ensure "EmitDate" is required (not null)
            if (EmitDate == null)
            {
                throw new InvalidDataException("EmitDate is a required property for AnalyticsSessionMetric and cannot be null");
            }
            else
            {
                this.EmitDate = EmitDate;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Unique name of this metric
        /// </summary>
        /// <value>Unique name of this metric</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The metric value
        /// </summary>
        /// <value>The metric value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public long? Value { get; set; }
        
        
        
        /// <summary>
        /// Metric emission date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Metric emission date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="emitDate", EmitDefaultValue=false)]
        public DateTime? EmitDate { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSessionMetric {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  Value: ").Append(Value).Append("\n");
            
            sb.Append("  EmitDate: ").Append(EmitDate).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnalyticsSessionMetric);
        }

        /// <summary>
        /// Returns true if AnalyticsSessionMetric instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsSessionMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSessionMetric other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.EmitDate == other.EmitDate ||
                    this.EmitDate != null &&
                    this.EmitDate.Equals(other.EmitDate)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.EmitDate != null)
                    hash = hash * 59 + this.EmitDate.GetHashCode();
                
                return hash;
            }
        }
    }

}
