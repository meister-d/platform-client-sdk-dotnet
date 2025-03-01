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
    /// CreateQueueRequest
    /// </summary>
    [DataContract]
    public partial class CreateQueueRequest :  IEquatable<CreateQueueRequest>
    {
        /// <summary>
        /// The Scoring Method for the queue.
        /// </summary>
        /// <value>The Scoring Method for the queue.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScoringMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Timestampandpriority for "TimestampAndPriority"
            /// </summary>
            [EnumMember(Value = "TimestampAndPriority")]
            Timestampandpriority,
            
            /// <summary>
            /// Enum Priorityonly for "PriorityOnly"
            /// </summary>
            [EnumMember(Value = "PriorityOnly")]
            Priorityonly
        }
        /// <summary>
        /// The Last Agent Routing Mode for the queue.
        /// </summary>
        /// <value>The Last Agent Routing Mode for the queue.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LastAgentRoutingModeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Queuemembersonly for "QueueMembersOnly"
            /// </summary>
            [EnumMember(Value = "QueueMembersOnly")]
            Queuemembersonly,
            
            /// <summary>
            /// Enum Anyagent for "AnyAgent"
            /// </summary>
            [EnumMember(Value = "AnyAgent")]
            Anyagent
        }
        /// <summary>
        /// The skill evaluation method to use when routing conversations.
        /// </summary>
        /// <value>The skill evaluation method to use when routing conversations.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SkillEvaluationMethodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Best for "BEST"
            /// </summary>
            [EnumMember(Value = "BEST")]
            Best,
            
            /// <summary>
            /// Enum All for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            All
        }
        /// <summary>
        /// The Scoring Method for the queue.
        /// </summary>
        /// <value>The Scoring Method for the queue.</value>
        [DataMember(Name="scoringMethod", EmitDefaultValue=false)]
        public ScoringMethodEnum? ScoringMethod { get; set; }
        /// <summary>
        /// The Last Agent Routing Mode for the queue.
        /// </summary>
        /// <value>The Last Agent Routing Mode for the queue.</value>
        [DataMember(Name="lastAgentRoutingMode", EmitDefaultValue=false)]
        public LastAgentRoutingModeEnum? LastAgentRoutingMode { get; set; }
        /// <summary>
        /// The skill evaluation method to use when routing conversations.
        /// </summary>
        /// <value>The skill evaluation method to use when routing conversations.</value>
        [DataMember(Name="skillEvaluationMethod", EmitDefaultValue=false)]
        public SkillEvaluationMethodEnum? SkillEvaluationMethod { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateQueueRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueueRequest" /> class.
        /// </summary>
        /// <param name="Name">The queue name (required).</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">The queue description..</param>
        /// <param name="DateCreated">The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The ID of the user that last modified the queue..</param>
        /// <param name="CreatedBy">The ID of the user that created the queue..</param>
        /// <param name="MediaSettings">The media settings for the queue..</param>
        /// <param name="RoutingRules">The routing rules for the queue, used for Preferred Agent Routing..</param>
        /// <param name="ConditionalGroupRouting">The Conditional Group Routing settings for the queue..</param>
        /// <param name="Bullseye">The bullseye settings for the queue..</param>
        /// <param name="ScoringMethod">The Scoring Method for the queue..</param>
        /// <param name="LastAgentRoutingMode">The Last Agent Routing Mode for the queue..</param>
        /// <param name="AcwSettings">The ACW settings for the queue..</param>
        /// <param name="SkillEvaluationMethod">The skill evaluation method to use when routing conversations..</param>
        /// <param name="MemberGroups">The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes..</param>
        /// <param name="QueueFlow">The in-queue flow to use for call conversations waiting in queue..</param>
        /// <param name="EmailInQueueFlow">The in-queue flow to use for email conversations waiting in queue..</param>
        /// <param name="MessageInQueueFlow">The in-queue flow to use for message conversations waiting in queue..</param>
        /// <param name="WhisperPrompt">The prompt used for whisper on the queue, if configured..</param>
        /// <param name="OnHoldPrompt">The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play..</param>
        /// <param name="AutoAnswerOnly">Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered..</param>
        /// <param name="CannedResponseLibraries">Canned response library IDs and mode with which they are associated with the queue.</param>
        /// <param name="EnableTranscription">Indicates whether voice transcription is enabled for this queue..</param>
        /// <param name="EnableAudioMonitoring">Indicates whether audio monitoring is enabled for this queue..</param>
        /// <param name="EnableManualAssignment">Indicates whether manual assignment is enabled for this queue..</param>
        /// <param name="AgentOwnedRouting">The Agent Owned Routing settings for the queue.</param>
        /// <param name="DirectRouting">The Direct Routing settings for the queue.</param>
        /// <param name="CallingPartyName">The name to use for caller identification for outbound calls from this queue..</param>
        /// <param name="CallingPartyNumber">The phone number to use for caller identification for outbound calls from this queue..</param>
        /// <param name="DefaultScripts">The default script Ids for the communication types..</param>
        /// <param name="OutboundMessagingAddresses">The messaging addresses for the queue..</param>
        /// <param name="OutboundEmailAddress">The default email address to use for outbound email from this queue..</param>
        /// <param name="PeerId">The ID of an associated external queue..</param>
        /// <param name="SuppressInQueueCallRecording">Indicates whether recording in-queue calls is suppressed for this queue..</param>
        /// <param name="SourceQueueId">The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue..</param>
        public CreateQueueRequest(string Name = null, WritableDivision Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, QueueMediaSettings MediaSettings = null, List<RoutingRule> RoutingRules = null, ConditionalGroupRouting ConditionalGroupRouting = null, Bullseye Bullseye = null, ScoringMethodEnum? ScoringMethod = null, LastAgentRoutingModeEnum? LastAgentRoutingMode = null, AcwSettings AcwSettings = null, SkillEvaluationMethodEnum? SkillEvaluationMethod = null, List<MemberGroup> MemberGroups = null, DomainEntityRef QueueFlow = null, DomainEntityRef EmailInQueueFlow = null, DomainEntityRef MessageInQueueFlow = null, DomainEntityRef WhisperPrompt = null, DomainEntityRef OnHoldPrompt = null, bool? AutoAnswerOnly = null, CannedResponseLibraries CannedResponseLibraries = null, bool? EnableTranscription = null, bool? EnableAudioMonitoring = null, bool? EnableManualAssignment = null, AgentOwnedRouting AgentOwnedRouting = null, DirectRouting DirectRouting = null, string CallingPartyName = null, string CallingPartyNumber = null, Dictionary<string, Script> DefaultScripts = null, QueueMessagingAddresses OutboundMessagingAddresses = null, QueueEmailAddress OutboundEmailAddress = null, string PeerId = null, bool? SuppressInQueueCallRecording = null, string SourceQueueId = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.MediaSettings = MediaSettings;
            this.RoutingRules = RoutingRules;
            this.ConditionalGroupRouting = ConditionalGroupRouting;
            this.Bullseye = Bullseye;
            this.ScoringMethod = ScoringMethod;
            this.LastAgentRoutingMode = LastAgentRoutingMode;
            this.AcwSettings = AcwSettings;
            this.SkillEvaluationMethod = SkillEvaluationMethod;
            this.MemberGroups = MemberGroups;
            this.QueueFlow = QueueFlow;
            this.EmailInQueueFlow = EmailInQueueFlow;
            this.MessageInQueueFlow = MessageInQueueFlow;
            this.WhisperPrompt = WhisperPrompt;
            this.OnHoldPrompt = OnHoldPrompt;
            this.AutoAnswerOnly = AutoAnswerOnly;
            this.CannedResponseLibraries = CannedResponseLibraries;
            this.EnableTranscription = EnableTranscription;
            this.EnableAudioMonitoring = EnableAudioMonitoring;
            this.EnableManualAssignment = EnableManualAssignment;
            this.AgentOwnedRouting = AgentOwnedRouting;
            this.DirectRouting = DirectRouting;
            this.CallingPartyName = CallingPartyName;
            this.CallingPartyNumber = CallingPartyNumber;
            this.DefaultScripts = DefaultScripts;
            this.OutboundMessagingAddresses = OutboundMessagingAddresses;
            this.OutboundEmailAddress = OutboundEmailAddress;
            this.PeerId = PeerId;
            this.SuppressInQueueCallRecording = SuppressInQueueCallRecording;
            this.SourceQueueId = SourceQueueId;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The queue name
        /// </summary>
        /// <value>The queue name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableDivision Division { get; set; }



        /// <summary>
        /// The queue description.
        /// </summary>
        /// <value>The queue description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date the queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date of the last modification to the queue. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The ID of the user that last modified the queue.
        /// </summary>
        /// <value>The ID of the user that last modified the queue.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }



        /// <summary>
        /// The ID of the user that created the queue.
        /// </summary>
        /// <value>The ID of the user that created the queue.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }



        /// <summary>
        /// The total number of members in the queue.
        /// </summary>
        /// <value>The total number of members in the queue.</value>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; private set; }



        /// <summary>
        /// The number of user members (i.e., non-group members) in the queue.
        /// </summary>
        /// <value>The number of user members (i.e., non-group members) in the queue.</value>
        [DataMember(Name="userMemberCount", EmitDefaultValue=false)]
        public int? UserMemberCount { get; private set; }



        /// <summary>
        /// The number of joined members in the queue.
        /// </summary>
        /// <value>The number of joined members in the queue.</value>
        [DataMember(Name="joinedMemberCount", EmitDefaultValue=false)]
        public int? JoinedMemberCount { get; private set; }



        /// <summary>
        /// The media settings for the queue.
        /// </summary>
        /// <value>The media settings for the queue.</value>
        [DataMember(Name="mediaSettings", EmitDefaultValue=false)]
        public QueueMediaSettings MediaSettings { get; set; }



        /// <summary>
        /// The routing rules for the queue, used for Preferred Agent Routing.
        /// </summary>
        /// <value>The routing rules for the queue, used for Preferred Agent Routing.</value>
        [DataMember(Name="routingRules", EmitDefaultValue=false)]
        public List<RoutingRule> RoutingRules { get; set; }



        /// <summary>
        /// The Conditional Group Routing settings for the queue.
        /// </summary>
        /// <value>The Conditional Group Routing settings for the queue.</value>
        [DataMember(Name="conditionalGroupRouting", EmitDefaultValue=false)]
        public ConditionalGroupRouting ConditionalGroupRouting { get; set; }



        /// <summary>
        /// The bullseye settings for the queue.
        /// </summary>
        /// <value>The bullseye settings for the queue.</value>
        [DataMember(Name="bullseye", EmitDefaultValue=false)]
        public Bullseye Bullseye { get; set; }







        /// <summary>
        /// The ACW settings for the queue.
        /// </summary>
        /// <value>The ACW settings for the queue.</value>
        [DataMember(Name="acwSettings", EmitDefaultValue=false)]
        public AcwSettings AcwSettings { get; set; }





        /// <summary>
        /// The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.
        /// </summary>
        /// <value>The groups of agents associated with the queue, if any.  Queue membership will update to match group membership changes.</value>
        [DataMember(Name="memberGroups", EmitDefaultValue=false)]
        public List<MemberGroup> MemberGroups { get; set; }



        /// <summary>
        /// The in-queue flow to use for call conversations waiting in queue.
        /// </summary>
        /// <value>The in-queue flow to use for call conversations waiting in queue.</value>
        [DataMember(Name="queueFlow", EmitDefaultValue=false)]
        public DomainEntityRef QueueFlow { get; set; }



        /// <summary>
        /// The in-queue flow to use for email conversations waiting in queue.
        /// </summary>
        /// <value>The in-queue flow to use for email conversations waiting in queue.</value>
        [DataMember(Name="emailInQueueFlow", EmitDefaultValue=false)]
        public DomainEntityRef EmailInQueueFlow { get; set; }



        /// <summary>
        /// The in-queue flow to use for message conversations waiting in queue.
        /// </summary>
        /// <value>The in-queue flow to use for message conversations waiting in queue.</value>
        [DataMember(Name="messageInQueueFlow", EmitDefaultValue=false)]
        public DomainEntityRef MessageInQueueFlow { get; set; }



        /// <summary>
        /// The prompt used for whisper on the queue, if configured.
        /// </summary>
        /// <value>The prompt used for whisper on the queue, if configured.</value>
        [DataMember(Name="whisperPrompt", EmitDefaultValue=false)]
        public DomainEntityRef WhisperPrompt { get; set; }



        /// <summary>
        /// The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.
        /// </summary>
        /// <value>The audio to be played when calls on this queue are on hold. If not configured, the default on-hold music will play.</value>
        [DataMember(Name="onHoldPrompt", EmitDefaultValue=false)]
        public DomainEntityRef OnHoldPrompt { get; set; }



        /// <summary>
        /// Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.
        /// </summary>
        /// <value>Specifies whether the configured whisper should play for all ACD calls, or only for those which are auto-answered.</value>
        [DataMember(Name="autoAnswerOnly", EmitDefaultValue=false)]
        public bool? AutoAnswerOnly { get; set; }



        /// <summary>
        /// Canned response library IDs and mode with which they are associated with the queue
        /// </summary>
        /// <value>Canned response library IDs and mode with which they are associated with the queue</value>
        [DataMember(Name="cannedResponseLibraries", EmitDefaultValue=false)]
        public CannedResponseLibraries CannedResponseLibraries { get; set; }



        /// <summary>
        /// Indicates whether voice transcription is enabled for this queue.
        /// </summary>
        /// <value>Indicates whether voice transcription is enabled for this queue.</value>
        [DataMember(Name="enableTranscription", EmitDefaultValue=false)]
        public bool? EnableTranscription { get; set; }



        /// <summary>
        /// Indicates whether audio monitoring is enabled for this queue.
        /// </summary>
        /// <value>Indicates whether audio monitoring is enabled for this queue.</value>
        [DataMember(Name="enableAudioMonitoring", EmitDefaultValue=false)]
        public bool? EnableAudioMonitoring { get; set; }



        /// <summary>
        /// Indicates whether manual assignment is enabled for this queue.
        /// </summary>
        /// <value>Indicates whether manual assignment is enabled for this queue.</value>
        [DataMember(Name="enableManualAssignment", EmitDefaultValue=false)]
        public bool? EnableManualAssignment { get; set; }



        /// <summary>
        /// The Agent Owned Routing settings for the queue
        /// </summary>
        /// <value>The Agent Owned Routing settings for the queue</value>
        [DataMember(Name="agentOwnedRouting", EmitDefaultValue=false)]
        public AgentOwnedRouting AgentOwnedRouting { get; set; }



        /// <summary>
        /// The Direct Routing settings for the queue
        /// </summary>
        /// <value>The Direct Routing settings for the queue</value>
        [DataMember(Name="directRouting", EmitDefaultValue=false)]
        public DirectRouting DirectRouting { get; set; }



        /// <summary>
        /// The name to use for caller identification for outbound calls from this queue.
        /// </summary>
        /// <value>The name to use for caller identification for outbound calls from this queue.</value>
        [DataMember(Name="callingPartyName", EmitDefaultValue=false)]
        public string CallingPartyName { get; set; }



        /// <summary>
        /// The phone number to use for caller identification for outbound calls from this queue.
        /// </summary>
        /// <value>The phone number to use for caller identification for outbound calls from this queue.</value>
        [DataMember(Name="callingPartyNumber", EmitDefaultValue=false)]
        public string CallingPartyNumber { get; set; }



        /// <summary>
        /// The default script Ids for the communication types.
        /// </summary>
        /// <value>The default script Ids for the communication types.</value>
        [DataMember(Name="defaultScripts", EmitDefaultValue=false)]
        public Dictionary<string, Script> DefaultScripts { get; set; }



        /// <summary>
        /// The messaging addresses for the queue.
        /// </summary>
        /// <value>The messaging addresses for the queue.</value>
        [DataMember(Name="outboundMessagingAddresses", EmitDefaultValue=false)]
        public QueueMessagingAddresses OutboundMessagingAddresses { get; set; }



        /// <summary>
        /// The default email address to use for outbound email from this queue.
        /// </summary>
        /// <value>The default email address to use for outbound email from this queue.</value>
        [DataMember(Name="outboundEmailAddress", EmitDefaultValue=false)]
        public QueueEmailAddress OutboundEmailAddress { get; set; }



        /// <summary>
        /// The ID of an associated external queue.
        /// </summary>
        /// <value>The ID of an associated external queue.</value>
        [DataMember(Name="peerId", EmitDefaultValue=false)]
        public string PeerId { get; set; }



        /// <summary>
        /// Indicates whether recording in-queue calls is suppressed for this queue.
        /// </summary>
        /// <value>Indicates whether recording in-queue calls is suppressed for this queue.</value>
        [DataMember(Name="suppressInQueueCallRecording", EmitDefaultValue=false)]
        public bool? SuppressInQueueCallRecording { get; set; }



        /// <summary>
        /// The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue.
        /// </summary>
        /// <value>The id of an existing queue to copy the settings (does not include GPR settings) from when creating a new queue.</value>
        [DataMember(Name="sourceQueueId", EmitDefaultValue=false)]
        public string SourceQueueId { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateQueueRequest {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  UserMemberCount: ").Append(UserMemberCount).Append("\n");
            sb.Append("  JoinedMemberCount: ").Append(JoinedMemberCount).Append("\n");
            sb.Append("  MediaSettings: ").Append(MediaSettings).Append("\n");
            sb.Append("  RoutingRules: ").Append(RoutingRules).Append("\n");
            sb.Append("  ConditionalGroupRouting: ").Append(ConditionalGroupRouting).Append("\n");
            sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
            sb.Append("  ScoringMethod: ").Append(ScoringMethod).Append("\n");
            sb.Append("  LastAgentRoutingMode: ").Append(LastAgentRoutingMode).Append("\n");
            sb.Append("  AcwSettings: ").Append(AcwSettings).Append("\n");
            sb.Append("  SkillEvaluationMethod: ").Append(SkillEvaluationMethod).Append("\n");
            sb.Append("  MemberGroups: ").Append(MemberGroups).Append("\n");
            sb.Append("  QueueFlow: ").Append(QueueFlow).Append("\n");
            sb.Append("  EmailInQueueFlow: ").Append(EmailInQueueFlow).Append("\n");
            sb.Append("  MessageInQueueFlow: ").Append(MessageInQueueFlow).Append("\n");
            sb.Append("  WhisperPrompt: ").Append(WhisperPrompt).Append("\n");
            sb.Append("  OnHoldPrompt: ").Append(OnHoldPrompt).Append("\n");
            sb.Append("  AutoAnswerOnly: ").Append(AutoAnswerOnly).Append("\n");
            sb.Append("  CannedResponseLibraries: ").Append(CannedResponseLibraries).Append("\n");
            sb.Append("  EnableTranscription: ").Append(EnableTranscription).Append("\n");
            sb.Append("  EnableAudioMonitoring: ").Append(EnableAudioMonitoring).Append("\n");
            sb.Append("  EnableManualAssignment: ").Append(EnableManualAssignment).Append("\n");
            sb.Append("  AgentOwnedRouting: ").Append(AgentOwnedRouting).Append("\n");
            sb.Append("  DirectRouting: ").Append(DirectRouting).Append("\n");
            sb.Append("  CallingPartyName: ").Append(CallingPartyName).Append("\n");
            sb.Append("  CallingPartyNumber: ").Append(CallingPartyNumber).Append("\n");
            sb.Append("  DefaultScripts: ").Append(DefaultScripts).Append("\n");
            sb.Append("  OutboundMessagingAddresses: ").Append(OutboundMessagingAddresses).Append("\n");
            sb.Append("  OutboundEmailAddress: ").Append(OutboundEmailAddress).Append("\n");
            sb.Append("  PeerId: ").Append(PeerId).Append("\n");
            sb.Append("  SuppressInQueueCallRecording: ").Append(SuppressInQueueCallRecording).Append("\n");
            sb.Append("  SourceQueueId: ").Append(SourceQueueId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as CreateQueueRequest);
        }

        /// <summary>
        /// Returns true if CreateQueueRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateQueueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateQueueRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.MemberCount == other.MemberCount ||
                    this.MemberCount != null &&
                    this.MemberCount.Equals(other.MemberCount)
                ) &&
                (
                    this.UserMemberCount == other.UserMemberCount ||
                    this.UserMemberCount != null &&
                    this.UserMemberCount.Equals(other.UserMemberCount)
                ) &&
                (
                    this.JoinedMemberCount == other.JoinedMemberCount ||
                    this.JoinedMemberCount != null &&
                    this.JoinedMemberCount.Equals(other.JoinedMemberCount)
                ) &&
                (
                    this.MediaSettings == other.MediaSettings ||
                    this.MediaSettings != null &&
                    this.MediaSettings.Equals(other.MediaSettings)
                ) &&
                (
                    this.RoutingRules == other.RoutingRules ||
                    this.RoutingRules != null &&
                    this.RoutingRules.SequenceEqual(other.RoutingRules)
                ) &&
                (
                    this.ConditionalGroupRouting == other.ConditionalGroupRouting ||
                    this.ConditionalGroupRouting != null &&
                    this.ConditionalGroupRouting.Equals(other.ConditionalGroupRouting)
                ) &&
                (
                    this.Bullseye == other.Bullseye ||
                    this.Bullseye != null &&
                    this.Bullseye.Equals(other.Bullseye)
                ) &&
                (
                    this.ScoringMethod == other.ScoringMethod ||
                    this.ScoringMethod != null &&
                    this.ScoringMethod.Equals(other.ScoringMethod)
                ) &&
                (
                    this.LastAgentRoutingMode == other.LastAgentRoutingMode ||
                    this.LastAgentRoutingMode != null &&
                    this.LastAgentRoutingMode.Equals(other.LastAgentRoutingMode)
                ) &&
                (
                    this.AcwSettings == other.AcwSettings ||
                    this.AcwSettings != null &&
                    this.AcwSettings.Equals(other.AcwSettings)
                ) &&
                (
                    this.SkillEvaluationMethod == other.SkillEvaluationMethod ||
                    this.SkillEvaluationMethod != null &&
                    this.SkillEvaluationMethod.Equals(other.SkillEvaluationMethod)
                ) &&
                (
                    this.MemberGroups == other.MemberGroups ||
                    this.MemberGroups != null &&
                    this.MemberGroups.SequenceEqual(other.MemberGroups)
                ) &&
                (
                    this.QueueFlow == other.QueueFlow ||
                    this.QueueFlow != null &&
                    this.QueueFlow.Equals(other.QueueFlow)
                ) &&
                (
                    this.EmailInQueueFlow == other.EmailInQueueFlow ||
                    this.EmailInQueueFlow != null &&
                    this.EmailInQueueFlow.Equals(other.EmailInQueueFlow)
                ) &&
                (
                    this.MessageInQueueFlow == other.MessageInQueueFlow ||
                    this.MessageInQueueFlow != null &&
                    this.MessageInQueueFlow.Equals(other.MessageInQueueFlow)
                ) &&
                (
                    this.WhisperPrompt == other.WhisperPrompt ||
                    this.WhisperPrompt != null &&
                    this.WhisperPrompt.Equals(other.WhisperPrompt)
                ) &&
                (
                    this.OnHoldPrompt == other.OnHoldPrompt ||
                    this.OnHoldPrompt != null &&
                    this.OnHoldPrompt.Equals(other.OnHoldPrompt)
                ) &&
                (
                    this.AutoAnswerOnly == other.AutoAnswerOnly ||
                    this.AutoAnswerOnly != null &&
                    this.AutoAnswerOnly.Equals(other.AutoAnswerOnly)
                ) &&
                (
                    this.CannedResponseLibraries == other.CannedResponseLibraries ||
                    this.CannedResponseLibraries != null &&
                    this.CannedResponseLibraries.Equals(other.CannedResponseLibraries)
                ) &&
                (
                    this.EnableTranscription == other.EnableTranscription ||
                    this.EnableTranscription != null &&
                    this.EnableTranscription.Equals(other.EnableTranscription)
                ) &&
                (
                    this.EnableAudioMonitoring == other.EnableAudioMonitoring ||
                    this.EnableAudioMonitoring != null &&
                    this.EnableAudioMonitoring.Equals(other.EnableAudioMonitoring)
                ) &&
                (
                    this.EnableManualAssignment == other.EnableManualAssignment ||
                    this.EnableManualAssignment != null &&
                    this.EnableManualAssignment.Equals(other.EnableManualAssignment)
                ) &&
                (
                    this.AgentOwnedRouting == other.AgentOwnedRouting ||
                    this.AgentOwnedRouting != null &&
                    this.AgentOwnedRouting.Equals(other.AgentOwnedRouting)
                ) &&
                (
                    this.DirectRouting == other.DirectRouting ||
                    this.DirectRouting != null &&
                    this.DirectRouting.Equals(other.DirectRouting)
                ) &&
                (
                    this.CallingPartyName == other.CallingPartyName ||
                    this.CallingPartyName != null &&
                    this.CallingPartyName.Equals(other.CallingPartyName)
                ) &&
                (
                    this.CallingPartyNumber == other.CallingPartyNumber ||
                    this.CallingPartyNumber != null &&
                    this.CallingPartyNumber.Equals(other.CallingPartyNumber)
                ) &&
                (
                    this.DefaultScripts == other.DefaultScripts ||
                    this.DefaultScripts != null &&
                    this.DefaultScripts.SequenceEqual(other.DefaultScripts)
                ) &&
                (
                    this.OutboundMessagingAddresses == other.OutboundMessagingAddresses ||
                    this.OutboundMessagingAddresses != null &&
                    this.OutboundMessagingAddresses.Equals(other.OutboundMessagingAddresses)
                ) &&
                (
                    this.OutboundEmailAddress == other.OutboundEmailAddress ||
                    this.OutboundEmailAddress != null &&
                    this.OutboundEmailAddress.Equals(other.OutboundEmailAddress)
                ) &&
                (
                    this.PeerId == other.PeerId ||
                    this.PeerId != null &&
                    this.PeerId.Equals(other.PeerId)
                ) &&
                (
                    this.SuppressInQueueCallRecording == other.SuppressInQueueCallRecording ||
                    this.SuppressInQueueCallRecording != null &&
                    this.SuppressInQueueCallRecording.Equals(other.SuppressInQueueCallRecording)
                ) &&
                (
                    this.SourceQueueId == other.SourceQueueId ||
                    this.SourceQueueId != null &&
                    this.SourceQueueId.Equals(other.SourceQueueId)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();

                if (this.MemberCount != null)
                    hash = hash * 59 + this.MemberCount.GetHashCode();

                if (this.UserMemberCount != null)
                    hash = hash * 59 + this.UserMemberCount.GetHashCode();

                if (this.JoinedMemberCount != null)
                    hash = hash * 59 + this.JoinedMemberCount.GetHashCode();

                if (this.MediaSettings != null)
                    hash = hash * 59 + this.MediaSettings.GetHashCode();

                if (this.RoutingRules != null)
                    hash = hash * 59 + this.RoutingRules.GetHashCode();

                if (this.ConditionalGroupRouting != null)
                    hash = hash * 59 + this.ConditionalGroupRouting.GetHashCode();

                if (this.Bullseye != null)
                    hash = hash * 59 + this.Bullseye.GetHashCode();

                if (this.ScoringMethod != null)
                    hash = hash * 59 + this.ScoringMethod.GetHashCode();

                if (this.LastAgentRoutingMode != null)
                    hash = hash * 59 + this.LastAgentRoutingMode.GetHashCode();

                if (this.AcwSettings != null)
                    hash = hash * 59 + this.AcwSettings.GetHashCode();

                if (this.SkillEvaluationMethod != null)
                    hash = hash * 59 + this.SkillEvaluationMethod.GetHashCode();

                if (this.MemberGroups != null)
                    hash = hash * 59 + this.MemberGroups.GetHashCode();

                if (this.QueueFlow != null)
                    hash = hash * 59 + this.QueueFlow.GetHashCode();

                if (this.EmailInQueueFlow != null)
                    hash = hash * 59 + this.EmailInQueueFlow.GetHashCode();

                if (this.MessageInQueueFlow != null)
                    hash = hash * 59 + this.MessageInQueueFlow.GetHashCode();

                if (this.WhisperPrompt != null)
                    hash = hash * 59 + this.WhisperPrompt.GetHashCode();

                if (this.OnHoldPrompt != null)
                    hash = hash * 59 + this.OnHoldPrompt.GetHashCode();

                if (this.AutoAnswerOnly != null)
                    hash = hash * 59 + this.AutoAnswerOnly.GetHashCode();

                if (this.CannedResponseLibraries != null)
                    hash = hash * 59 + this.CannedResponseLibraries.GetHashCode();

                if (this.EnableTranscription != null)
                    hash = hash * 59 + this.EnableTranscription.GetHashCode();

                if (this.EnableAudioMonitoring != null)
                    hash = hash * 59 + this.EnableAudioMonitoring.GetHashCode();

                if (this.EnableManualAssignment != null)
                    hash = hash * 59 + this.EnableManualAssignment.GetHashCode();

                if (this.AgentOwnedRouting != null)
                    hash = hash * 59 + this.AgentOwnedRouting.GetHashCode();

                if (this.DirectRouting != null)
                    hash = hash * 59 + this.DirectRouting.GetHashCode();

                if (this.CallingPartyName != null)
                    hash = hash * 59 + this.CallingPartyName.GetHashCode();

                if (this.CallingPartyNumber != null)
                    hash = hash * 59 + this.CallingPartyNumber.GetHashCode();

                if (this.DefaultScripts != null)
                    hash = hash * 59 + this.DefaultScripts.GetHashCode();

                if (this.OutboundMessagingAddresses != null)
                    hash = hash * 59 + this.OutboundMessagingAddresses.GetHashCode();

                if (this.OutboundEmailAddress != null)
                    hash = hash * 59 + this.OutboundEmailAddress.GetHashCode();

                if (this.PeerId != null)
                    hash = hash * 59 + this.PeerId.GetHashCode();

                if (this.SuppressInQueueCallRecording != null)
                    hash = hash * 59 + this.SuppressInQueueCallRecording.GetHashCode();

                if (this.SourceQueueId != null)
                    hash = hash * 59 + this.SourceQueueId.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
