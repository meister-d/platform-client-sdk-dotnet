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
    /// SummaryAsyncAggregationQuery
    /// </summary>
    [DataContract]
    public partial class SummaryAsyncAggregationQuery :  IEquatable<SummaryAsyncAggregationQuery>
    {
        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum GroupByEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Conversationid for "conversationId"
            /// </summary>
            [EnumMember(Value = "conversationId")]
            Conversationid,
            
            /// <summary>
            /// Enum Errortype for "errorType"
            /// </summary>
            [EnumMember(Value = "errorType")]
            Errortype,
            
            /// <summary>
            /// Enum Language for "language"
            /// </summary>
            [EnumMember(Value = "language")]
            Language,
            
            /// <summary>
            /// Enum Mediatype for "mediaType"
            /// </summary>
            [EnumMember(Value = "mediaType")]
            Mediatype,
            
            /// <summary>
            /// Enum Messagetype for "messageType"
            /// </summary>
            [EnumMember(Value = "messageType")]
            Messagetype,
            
            /// <summary>
            /// Enum Queueid for "queueId"
            /// </summary>
            [EnumMember(Value = "queueId")]
            Queueid,
            
            /// <summary>
            /// Enum Summarygenerated for "summaryGenerated"
            /// </summary>
            [EnumMember(Value = "summaryGenerated")]
            Summarygenerated,
            
            /// <summary>
            /// Enum Summaryid for "summaryId"
            /// </summary>
            [EnumMember(Value = "summaryId")]
            Summaryid,
            
            /// <summary>
            /// Enum Triggersourceid for "triggerSourceId"
            /// </summary>
            [EnumMember(Value = "triggerSourceId")]
            Triggersourceid,
            
            /// <summary>
            /// Enum Triggersourcetype for "triggerSourceType"
            /// </summary>
            [EnumMember(Value = "triggerSourceType")]
            Triggersourcetype,
            
            /// <summary>
            /// Enum Userid for "userId"
            /// </summary>
            [EnumMember(Value = "userId")]
            Userid,
            
            /// <summary>
            /// Enum Wrapupcodesgenerated for "wrapupCodesGenerated"
            /// </summary>
            [EnumMember(Value = "wrapupCodesGenerated")]
            Wrapupcodesgenerated
        }
        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MetricsEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Nconversationsummaries for "nConversationSummaries"
            /// </summary>
            [EnumMember(Value = "nConversationSummaries")]
            Nconversationsummaries,
            
            /// <summary>
            /// Enum Tconversationsummary for "tConversationSummary"
            /// </summary>
            [EnumMember(Value = "tConversationSummary")]
            Tconversationsummary
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AlternateTimeDimensionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Eventtime for "eventTime"
            /// </summary>
            [EnumMember(Value = "eventTime")]
            Eventtime
        }
        /// <summary>
        /// Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)
        /// </summary>
        /// <value>Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum QueryTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Groupby for "groupBy"
            /// </summary>
            [EnumMember(Value = "groupBy")]
            Groupby,
            
            /// <summary>
            /// Enum Topn for "topN"
            /// </summary>
            [EnumMember(Value = "topN")]
            Topn
        }
        /// <summary>
        /// Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.
        /// </summary>
        /// <value>Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event.</value>
        [DataMember(Name="alternateTimeDimension", EmitDefaultValue=false)]
        public AlternateTimeDimensionEnum? AlternateTimeDimension { get; set; }
        /// <summary>
        /// Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)
        /// </summary>
        /// <value>Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension)</value>
        [DataMember(Name="queryType", EmitDefaultValue=false)]
        public QueryTypeEnum? QueryType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAsyncAggregationQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SummaryAsyncAggregationQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryAsyncAggregationQuery" /> class.
        /// </summary>
        /// <param name="Interval">Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss (required).</param>
        /// <param name="Granularity">Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
        /// <param name="TimeZone">Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
        /// <param name="GroupBy">Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group..</param>
        /// <param name="Filter">Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters.</param>
        /// <param name="Metrics">Behaves like a SQL SELECT clause. Only named metrics will be retrieved. (required).</param>
        /// <param name="FlattenMultivaluedDimensions">Flattens any multivalued dimensions used in response groups (e.g. ['a','b','c']->'a,b,c').</param>
        /// <param name="Views">Custom derived metric views.</param>
        /// <param name="AlternateTimeDimension">Dimension to use as the alternative timestamp for data in the aggregate.  Choosing \"eventTime\" uses the actual time of the data event..</param>
        /// <param name="QueryType">Query type to use. Use groupBy for all matching results, and topN for just top N results for the requested metric (group by exactly 1 dimension).</param>
        /// <param name="Limit">How many results you want in the topN list. Only applicable for topN query type..</param>
        /// <param name="PageSize">The number of results per page.</param>
        public SummaryAsyncAggregationQuery(string Interval = null, string Granularity = null, string TimeZone = null, List<GroupByEnum> GroupBy = null, SummaryAggregateQueryFilter Filter = null, List<MetricsEnum> Metrics = null, bool? FlattenMultivaluedDimensions = null, List<SummaryAggregationView> Views = null, AlternateTimeDimensionEnum? AlternateTimeDimension = null, QueryTypeEnum? QueryType = null, int? Limit = null, int? PageSize = null)
        {
            this.Interval = Interval;
            this.Granularity = Granularity;
            this.TimeZone = TimeZone;
            this.GroupBy = GroupBy;
            this.Filter = Filter;
            this.Metrics = Metrics;
            this.FlattenMultivaluedDimensions = FlattenMultivaluedDimensions;
            this.Views = Views;
            this.AlternateTimeDimension = AlternateTimeDimension;
            this.QueryType = QueryType;
            this.Limit = Limit;
            this.PageSize = PageSize;
            
        }
        


        /// <summary>
        /// Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
        /// </summary>
        /// <value>Behaves like one clause in a SQL WHERE. Specifies the date and time range of data being queried. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }



        /// <summary>
        /// Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
        /// </summary>
        /// <value>Granularity aggregates metrics into subpartitions within the time interval specified. The default granularity is the same duration as the interval. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
        [DataMember(Name="granularity", EmitDefaultValue=false)]
        public string Granularity { get; set; }



        /// <summary>
        /// Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
        /// </summary>
        /// <value>Time zone context used to calculate response intervals (this allows resolving DST changes). The interval offset is used even when timeZone is specified. Default is UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.
        /// </summary>
        /// <value>Behaves like a SQL GROUPBY. Allows for multiple levels of grouping as a list of dimensions. Partitions resulting aggregate computations into distinct named subgroups rather than across the entire result set as if it were one group.</value>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public List<GroupByEnum> GroupBy { get; set; }



        /// <summary>
        /// Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters
        /// </summary>
        /// <value>Behaves like a SQL WHERE clause. This is ANDed with the interval parameter. Expresses boolean logical predicates as well as dimensional filters</value>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public SummaryAggregateQueryFilter Filter { get; set; }



        /// <summary>
        /// Behaves like a SQL SELECT clause. Only named metrics will be retrieved.
        /// </summary>
        /// <value>Behaves like a SQL SELECT clause. Only named metrics will be retrieved.</value>
        [DataMember(Name="metrics", EmitDefaultValue=false)]
        public List<MetricsEnum> Metrics { get; set; }



        /// <summary>
        /// Flattens any multivalued dimensions used in response groups (e.g. ['a','b','c']->'a,b,c')
        /// </summary>
        /// <value>Flattens any multivalued dimensions used in response groups (e.g. ['a','b','c']->'a,b,c')</value>
        [DataMember(Name="flattenMultivaluedDimensions", EmitDefaultValue=false)]
        public bool? FlattenMultivaluedDimensions { get; set; }



        /// <summary>
        /// Custom derived metric views
        /// </summary>
        /// <value>Custom derived metric views</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<SummaryAggregationView> Views { get; set; }







        /// <summary>
        /// How many results you want in the topN list. Only applicable for topN query type.
        /// </summary>
        /// <value>How many results you want in the topN list. Only applicable for topN query type.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }



        /// <summary>
        /// The number of results per page
        /// </summary>
        /// <value>The number of results per page</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryAsyncAggregationQuery {\n");

            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Granularity: ").Append(Granularity).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  FlattenMultivaluedDimensions: ").Append(FlattenMultivaluedDimensions).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  AlternateTimeDimension: ").Append(AlternateTimeDimension).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(obj as SummaryAsyncAggregationQuery);
        }

        /// <summary>
        /// Returns true if SummaryAsyncAggregationQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryAsyncAggregationQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryAsyncAggregationQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) &&
                (
                    this.Granularity == other.Granularity ||
                    this.Granularity != null &&
                    this.Granularity.Equals(other.Granularity)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.GroupBy == other.GroupBy ||
                    this.GroupBy != null &&
                    this.GroupBy.SequenceEqual(other.GroupBy)
                ) &&
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) &&
                (
                    this.Metrics == other.Metrics ||
                    this.Metrics != null &&
                    this.Metrics.SequenceEqual(other.Metrics)
                ) &&
                (
                    this.FlattenMultivaluedDimensions == other.FlattenMultivaluedDimensions ||
                    this.FlattenMultivaluedDimensions != null &&
                    this.FlattenMultivaluedDimensions.Equals(other.FlattenMultivaluedDimensions)
                ) &&
                (
                    this.Views == other.Views ||
                    this.Views != null &&
                    this.Views.SequenceEqual(other.Views)
                ) &&
                (
                    this.AlternateTimeDimension == other.AlternateTimeDimension ||
                    this.AlternateTimeDimension != null &&
                    this.AlternateTimeDimension.Equals(other.AlternateTimeDimension)
                ) &&
                (
                    this.QueryType == other.QueryType ||
                    this.QueryType != null &&
                    this.QueryType.Equals(other.QueryType)
                ) &&
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) &&
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
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
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();

                if (this.Granularity != null)
                    hash = hash * 59 + this.Granularity.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.GroupBy != null)
                    hash = hash * 59 + this.GroupBy.GetHashCode();

                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();

                if (this.Metrics != null)
                    hash = hash * 59 + this.Metrics.GetHashCode();

                if (this.FlattenMultivaluedDimensions != null)
                    hash = hash * 59 + this.FlattenMultivaluedDimensions.GetHashCode();

                if (this.Views != null)
                    hash = hash * 59 + this.Views.GetHashCode();

                if (this.AlternateTimeDimension != null)
                    hash = hash * 59 + this.AlternateTimeDimension.GetHashCode();

                if (this.QueryType != null)
                    hash = hash * 59 + this.QueryType.GetHashCode();

                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();

                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();

                return hash;
            }
        }
    }

}
