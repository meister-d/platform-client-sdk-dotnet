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
    /// BuShortTermForecastingSettings
    /// </summary>
    [DataContract]
    public partial class BuShortTermForecastingSettings :  IEquatable<BuShortTermForecastingSettings>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BuShortTermForecastingSettings" /> class.
        /// </summary>
        /// <param name="DefaultHistoryWeeks">The number of historical weeks to consider when creating a forecast. This setting is only used for legacy weighted average forecasts.</param>
        public BuShortTermForecastingSettings(int? DefaultHistoryWeeks = null)
        {
            this.DefaultHistoryWeeks = DefaultHistoryWeeks;
            
        }
        
        
        
        /// <summary>
        /// The number of historical weeks to consider when creating a forecast. This setting is only used for legacy weighted average forecasts
        /// </summary>
        /// <value>The number of historical weeks to consider when creating a forecast. This setting is only used for legacy weighted average forecasts</value>
        [DataMember(Name="defaultHistoryWeeks", EmitDefaultValue=false)]
        public int? DefaultHistoryWeeks { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuShortTermForecastingSettings {\n");
            
            sb.Append("  DefaultHistoryWeeks: ").Append(DefaultHistoryWeeks).Append("\n");
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
            return this.Equals(obj as BuShortTermForecastingSettings);
        }

        /// <summary>
        /// Returns true if BuShortTermForecastingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of BuShortTermForecastingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuShortTermForecastingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultHistoryWeeks == other.DefaultHistoryWeeks ||
                    this.DefaultHistoryWeeks != null &&
                    this.DefaultHistoryWeeks.Equals(other.DefaultHistoryWeeks)
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
                
                if (this.DefaultHistoryWeeks != null)
                    hash = hash * 59 + this.DefaultHistoryWeeks.GetHashCode();
                
                return hash;
            }
        }
    }

}