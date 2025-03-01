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
    /// ReportingExportMetadataJobResponse
    /// </summary>
    [DataContract]
    public partial class ReportingExportMetadataJobResponse :  IEquatable<ReportingExportMetadataJobResponse>
    {
        /// <summary>
        /// The view type of the export metadata
        /// </summary>
        /// <value>The view type of the export metadata</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ViewTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum QueuePerformanceSummaryView for "QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            QueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum QueuePerformanceDetailView for "QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_PERFORMANCE_DETAIL_VIEW")]
            QueuePerformanceDetailView,
            
            /// <summary>
            /// Enum InteractionSearchView for "INTERACTION_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_SEARCH_VIEW")]
            InteractionSearchView,
            
            /// <summary>
            /// Enum AgentPerformanceSummaryView for "AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_SUMMARY_VIEW")]
            AgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceDetailView for "AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_DETAIL_VIEW")]
            AgentPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentStatusSummaryView for "AGENT_STATUS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_SUMMARY_VIEW")]
            AgentStatusSummaryView,
            
            /// <summary>
            /// Enum AgentStatusDetailView for "AGENT_STATUS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_DETAIL_VIEW")]
            AgentStatusDetailView,
            
            /// <summary>
            /// Enum AgentEvaluationSummaryView for "AGENT_EVALUATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_SUMMARY_VIEW")]
            AgentEvaluationSummaryView,
            
            /// <summary>
            /// Enum AgentEvaluationDetailView for "AGENT_EVALUATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_DETAIL_VIEW")]
            AgentEvaluationDetailView,
            
            /// <summary>
            /// Enum AgentQueueDetailView for "AGENT_QUEUE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_DETAIL_VIEW")]
            AgentQueueDetailView,
            
            /// <summary>
            /// Enum AgentInteractionDetailView for "AGENT_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTION_DETAIL_VIEW")]
            AgentInteractionDetailView,
            
            /// <summary>
            /// Enum AbandonInsightsView for "ABANDON_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ABANDON_INSIGHTS_VIEW")]
            AbandonInsightsView,
            
            /// <summary>
            /// Enum SkillsPerformanceView for "SKILLS_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "SKILLS_PERFORMANCE_VIEW")]
            SkillsPerformanceView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceSummaryView for "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_SUMMARY_VIEW")]
            SurveyFormPerformanceSummaryView,
            
            /// <summary>
            /// Enum SurveyFormPerformanceDetailView for "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "SURVEY_FORM_PERFORMANCE_DETAIL_VIEW")]
            SurveyFormPerformanceDetailView,
            
            /// <summary>
            /// Enum DnisPerformanceSummaryView for "DNIS_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_SUMMARY_VIEW")]
            DnisPerformanceSummaryView,
            
            /// <summary>
            /// Enum DnisPerformanceDetailView for "DNIS_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "DNIS_PERFORMANCE_DETAIL_VIEW")]
            DnisPerformanceDetailView,
            
            /// <summary>
            /// Enum WrapUpPerformanceSummaryView for "WRAP_UP_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "WRAP_UP_PERFORMANCE_SUMMARY_VIEW")]
            WrapUpPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceDetailView for "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_DETAIL_VIEW")]
            AgentWrapUpPerformanceDetailView,
            
            /// <summary>
            /// Enum QueueActivitySummaryView for "QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_SUMMARY_VIEW")]
            QueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueActivityDetailView for "QUEUE_ACTIVITY_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ACTIVITY_DETAIL_VIEW")]
            QueueActivityDetailView,
            
            /// <summary>
            /// Enum AgentQueueActivitySummaryView for "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_QUEUE_ACTIVITY_SUMMARY_VIEW")]
            AgentQueueActivitySummaryView,
            
            /// <summary>
            /// Enum QueueAgentDetailView for "QUEUE_AGENT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_AGENT_DETAIL_VIEW")]
            QueueAgentDetailView,
            
            /// <summary>
            /// Enum QueueInteractionDetailView for "QUEUE_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_INTERACTION_DETAIL_VIEW")]
            QueueInteractionDetailView,
            
            /// <summary>
            /// Enum AgentScheduleDetailView for "AGENT_SCHEDULE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCHEDULE_DETAIL_VIEW")]
            AgentScheduleDetailView,
            
            /// <summary>
            /// Enum IvrPerformanceSummaryView for "IVR_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_SUMMARY_VIEW")]
            IvrPerformanceSummaryView,
            
            /// <summary>
            /// Enum IvrPerformanceDetailView for "IVR_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "IVR_PERFORMANCE_DETAIL_VIEW")]
            IvrPerformanceDetailView,
            
            /// <summary>
            /// Enum AnswerInsightsView for "ANSWER_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ANSWER_INSIGHTS_VIEW")]
            AnswerInsightsView,
            
            /// <summary>
            /// Enum HandleInsightsView for "HANDLE_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HANDLE_INSIGHTS_VIEW")]
            HandleInsightsView,
            
            /// <summary>
            /// Enum TalkInsightsView for "TALK_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "TALK_INSIGHTS_VIEW")]
            TalkInsightsView,
            
            /// <summary>
            /// Enum HoldInsightsView for "HOLD_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "HOLD_INSIGHTS_VIEW")]
            HoldInsightsView,
            
            /// <summary>
            /// Enum AcwInsightsView for "ACW_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "ACW_INSIGHTS_VIEW")]
            AcwInsightsView,
            
            /// <summary>
            /// Enum WaitInsightsView for "WAIT_INSIGHTS_VIEW"
            /// </summary>
            [EnumMember(Value = "WAIT_INSIGHTS_VIEW")]
            WaitInsightsView,
            
            /// <summary>
            /// Enum AgentWrapUpPerformanceIntervalDetailView for "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WRAP_UP_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            AgentWrapUpPerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowOutcomeSummaryView for "FLOW_OUTCOME_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_SUMMARY_VIEW")]
            FlowOutcomeSummaryView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceDetailView for "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_DETAIL_VIEW")]
            FlowOutcomePerformanceDetailView,
            
            /// <summary>
            /// Enum FlowOutcomePerformanceIntervalDetailView for "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_OUTCOME_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            FlowOutcomePerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum FlowDestinationSummaryView for "FLOW_DESTINATION_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_SUMMARY_VIEW")]
            FlowDestinationSummaryView,
            
            /// <summary>
            /// Enum FlowDestinationDetailView for "FLOW_DESTINATION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_DESTINATION_DETAIL_VIEW")]
            FlowDestinationDetailView,
            
            /// <summary>
            /// Enum ApiUsageView for "API_USAGE_VIEW"
            /// </summary>
            [EnumMember(Value = "API_USAGE_VIEW")]
            ApiUsageView,
            
            /// <summary>
            /// Enum ScheduledCallbacksView for "SCHEDULED_CALLBACKS_VIEW"
            /// </summary>
            [EnumMember(Value = "SCHEDULED_CALLBACKS_VIEW")]
            ScheduledCallbacksView,
            
            /// <summary>
            /// Enum ContentSearchView for "CONTENT_SEARCH_VIEW"
            /// </summary>
            [EnumMember(Value = "CONTENT_SEARCH_VIEW")]
            ContentSearchView,
            
            /// <summary>
            /// Enum LandingPage for "LANDING_PAGE"
            /// </summary>
            [EnumMember(Value = "LANDING_PAGE")]
            LandingPage,
            
            /// <summary>
            /// Enum DashboardSummary for "DASHBOARD_SUMMARY"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_SUMMARY")]
            DashboardSummary,
            
            /// <summary>
            /// Enum DashboardDetail for "DASHBOARD_DETAIL"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_DETAIL")]
            DashboardDetail,
            
            /// <summary>
            /// Enum DashboardUsers for "DASHBOARD_USERS"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_USERS")]
            DashboardUsers,
            
            /// <summary>
            /// Enum DashboardUsersDetail for "DASHBOARD_USERS_DETAIL"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_USERS_DETAIL")]
            DashboardUsersDetail,
            
            /// <summary>
            /// Enum JourneyActionMapSummaryView for "JOURNEY_ACTION_MAP_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_ACTION_MAP_SUMMARY_VIEW")]
            JourneyActionMapSummaryView,
            
            /// <summary>
            /// Enum JourneyOutcomeSummaryView for "JOURNEY_OUTCOME_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_OUTCOME_SUMMARY_VIEW")]
            JourneyOutcomeSummaryView,
            
            /// <summary>
            /// Enum JourneySegmentSummaryView for "JOURNEY_SEGMENT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "JOURNEY_SEGMENT_SUMMARY_VIEW")]
            JourneySegmentSummaryView,
            
            /// <summary>
            /// Enum AgentDevelopmentDetailView for "AGENT_DEVELOPMENT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_VIEW")]
            AgentDevelopmentDetailView,
            
            /// <summary>
            /// Enum AgentDevelopmentDetailMeView for "AGENT_DEVELOPMENT_DETAIL_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_DETAIL_ME_VIEW")]
            AgentDevelopmentDetailMeView,
            
            /// <summary>
            /// Enum AgentDevelopmentSummaryView for "AGENT_DEVELOPMENT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_DEVELOPMENT_SUMMARY_VIEW")]
            AgentDevelopmentSummaryView,
            
            /// <summary>
            /// Enum AgentPerformanceMeView for "AGENT_PERFORMANCE_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_ME_VIEW")]
            AgentPerformanceMeView,
            
            /// <summary>
            /// Enum AgentStatusMeView for "AGENT_STATUS_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_STATUS_ME_VIEW")]
            AgentStatusMeView,
            
            /// <summary>
            /// Enum AgentEvaluationMeView for "AGENT_EVALUATION_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_EVALUATION_ME_VIEW")]
            AgentEvaluationMeView,
            
            /// <summary>
            /// Enum AgentScorecardView for "AGENT_SCORECARD_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_VIEW")]
            AgentScorecardView,
            
            /// <summary>
            /// Enum AgentScorecardMeView for "AGENT_SCORECARD_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_ME_VIEW")]
            AgentScorecardMeView,
            
            /// <summary>
            /// Enum AgentGamificationLeadershipView for "AGENT_GAMIFICATION_LEADERSHIP_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_GAMIFICATION_LEADERSHIP_VIEW")]
            AgentGamificationLeadershipView,
            
            /// <summary>
            /// Enum AgentScheduleMeView for "AGENT_SCHEDULE_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCHEDULE_ME_VIEW")]
            AgentScheduleMeView,
            
            /// <summary>
            /// Enum BotPerformanceSummaryView for "BOT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "BOT_PERFORMANCE_SUMMARY_VIEW")]
            BotPerformanceSummaryView,
            
            /// <summary>
            /// Enum BotPerformanceDetailView for "BOT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "BOT_PERFORMANCE_DETAIL_VIEW")]
            BotPerformanceDetailView,
            
            /// <summary>
            /// Enum ScheduledExportsView for "SCHEDULED_EXPORTS_VIEW"
            /// </summary>
            [EnumMember(Value = "SCHEDULED_EXPORTS_VIEW")]
            ScheduledExportsView,
            
            /// <summary>
            /// Enum TopicTrendSummaryView for "TOPIC_TREND_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "TOPIC_TREND_SUMMARY_VIEW")]
            TopicTrendSummaryView,
            
            /// <summary>
            /// Enum TopicTrendDetailView for "TOPIC_TREND_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "TOPIC_TREND_DETAIL_VIEW")]
            TopicTrendDetailView,
            
            /// <summary>
            /// Enum ActionMapBlockedConstraintsDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_DETAIL_VIEW")]
            ActionMapBlockedConstraintsDetailView,
            
            /// <summary>
            /// Enum ActionMapBlockedConstraintsIntervalDetailView for "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "ACTION_MAP_BLOCKED_CONSTRAINTS_INTERVAL_DETAIL_VIEW")]
            ActionMapBlockedConstraintsIntervalDetailView,
            
            /// <summary>
            /// Enum FlowMilestonePerformanceDetailView for "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_DETAIL_VIEW")]
            FlowMilestonePerformanceDetailView,
            
            /// <summary>
            /// Enum FlowMilestonePerformanceIntervalDetailView for "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_MILESTONE_PERFORMANCE_INTERVAL_DETAIL_VIEW")]
            FlowMilestonePerformanceIntervalDetailView,
            
            /// <summary>
            /// Enum AgentTopicSummaryView for "AGENT_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TOPIC_SUMMARY_VIEW")]
            AgentTopicSummaryView,
            
            /// <summary>
            /// Enum AgentTopicDetailView for "AGENT_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TOPIC_DETAIL_VIEW")]
            AgentTopicDetailView,
            
            /// <summary>
            /// Enum QueueTopicSummaryView for "QUEUE_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_TOPIC_SUMMARY_VIEW")]
            QueueTopicSummaryView,
            
            /// <summary>
            /// Enum QueueTopicDetailView for "QUEUE_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_TOPIC_DETAIL_VIEW")]
            QueueTopicDetailView,
            
            /// <summary>
            /// Enum FlowTopicSummaryView for "FLOW_TOPIC_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_TOPIC_SUMMARY_VIEW")]
            FlowTopicSummaryView,
            
            /// <summary>
            /// Enum FlowTopicDetailView for "FLOW_TOPIC_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "FLOW_TOPIC_DETAIL_VIEW")]
            FlowTopicDetailView,
            
            /// <summary>
            /// Enum AgentInteractionsMeView for "AGENT_INTERACTIONS_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_INTERACTIONS_ME_VIEW")]
            AgentInteractionsMeView,
            
            /// <summary>
            /// Enum AlertRulesView for "ALERT_RULES_VIEW"
            /// </summary>
            [EnumMember(Value = "ALERT_RULES_VIEW")]
            AlertRulesView,
            
            /// <summary>
            /// Enum ConfigureAlertRuleView for "CONFIGURE_ALERT_RULE_VIEW"
            /// </summary>
            [EnumMember(Value = "CONFIGURE_ALERT_RULE_VIEW")]
            ConfigureAlertRuleView,
            
            /// <summary>
            /// Enum PredictiveRoutingView for "PREDICTIVE_ROUTING_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_VIEW")]
            PredictiveRoutingView,
            
            /// <summary>
            /// Enum PredictiveRoutingQueueOverview for "PREDICTIVE_ROUTING_QUEUE_OVERVIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_QUEUE_OVERVIEW")]
            PredictiveRoutingQueueOverview,
            
            /// <summary>
            /// Enum PredictiveRoutingModelView for "PREDICTIVE_ROUTING_MODEL_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_MODEL_VIEW")]
            PredictiveRoutingModelView,
            
            /// <summary>
            /// Enum PredictiveRoutingImpactView for "PREDICTIVE_ROUTING_IMPACT_VIEW"
            /// </summary>
            [EnumMember(Value = "PREDICTIVE_ROUTING_IMPACT_VIEW")]
            PredictiveRoutingImpactView,
            
            /// <summary>
            /// Enum DataActionsPerformanceSummaryView for "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_SUMMARY_VIEW")]
            DataActionsPerformanceSummaryView,
            
            /// <summary>
            /// Enum DataActionsPerformanceDetailView for "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "DATA_ACTIONS_PERFORMANCE_DETAIL_VIEW")]
            DataActionsPerformanceDetailView,
            
            /// <summary>
            /// Enum AgentTimelineSummaryView for "AGENT_TIMELINE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TIMELINE_SUMMARY_VIEW")]
            AgentTimelineSummaryView,
            
            /// <summary>
            /// Enum AgentTimelineDetailView for "AGENT_TIMELINE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_TIMELINE_DETAIL_VIEW")]
            AgentTimelineDetailView,
            
            /// <summary>
            /// Enum AgentLoginLogoutSummaryView for "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_LOGIN_LOGOUT_SUMMARY_VIEW")]
            AgentLoginLogoutSummaryView,
            
            /// <summary>
            /// Enum AgentLoginLogoutDetailView for "AGENT_LOGIN_LOGOUT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_LOGIN_LOGOUT_DETAIL_VIEW")]
            AgentLoginLogoutDetailView,
            
            /// <summary>
            /// Enum CampaignPerformanceSummaryView for "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_PERFORMANCE_SUMMARY_VIEW")]
            CampaignPerformanceSummaryView,
            
            /// <summary>
            /// Enum CampaignPerformanceDetailView for "CAMPAIGN_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_PERFORMANCE_DETAIL_VIEW")]
            CampaignPerformanceDetailView,
            
            /// <summary>
            /// Enum KnowledgePerformanceView for "KNOWLEDGE_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "KNOWLEDGE_PERFORMANCE_VIEW")]
            KnowledgePerformanceView,
            
            /// <summary>
            /// Enum AgentScorecardInsightsSummaryView for "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_SUMMARY_VIEW")]
            AgentScorecardInsightsSummaryView,
            
            /// <summary>
            /// Enum AgentScorecardInsightsDetailView for "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_SCORECARD_INSIGHTS_DETAIL_VIEW")]
            AgentScorecardInsightsDetailView,
            
            /// <summary>
            /// Enum QueueWrapupDetailView for "QUEUE_WRAPUP_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WRAPUP_DETAIL_VIEW")]
            QueueWrapupDetailView,
            
            /// <summary>
            /// Enum InteractionDetailView for "INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "INTERACTION_DETAIL_VIEW")]
            InteractionDetailView,
            
            /// <summary>
            /// Enum CampaignInteractionDetailView for "CAMPAIGN_INTERACTION_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_INTERACTION_DETAIL_VIEW")]
            CampaignInteractionDetailView,
            
            /// <summary>
            /// Enum CampaignAttemptDetailView for "CAMPAIGN_ATTEMPT_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "CAMPAIGN_ATTEMPT_DETAIL_VIEW")]
            CampaignAttemptDetailView,
            
            /// <summary>
            /// Enum WorkitemPerformanceSummaryView for "WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            WorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentAssistPerformanceView for "AGENT_ASSIST_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_ASSIST_PERFORMANCE_VIEW")]
            AgentAssistPerformanceView,
            
            /// <summary>
            /// Enum ContactCenterPerformanceView for "CONTACT_CENTER_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "CONTACT_CENTER_PERFORMANCE_VIEW")]
            ContactCenterPerformanceView,
            
            /// <summary>
            /// Enum QueueRoutingPerformanceView for "QUEUE_ROUTING_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_ROUTING_PERFORMANCE_VIEW")]
            QueueRoutingPerformanceView,
            
            /// <summary>
            /// Enum AgentWorkitemPerformanceSummaryView for "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            AgentWorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum AgentWorkitemPerformanceDetailView for "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
            AgentWorkitemPerformanceDetailView,
            
            /// <summary>
            /// Enum QueueWorkitemPerformanceSummaryView for "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_SUMMARY_VIEW")]
            QueueWorkitemPerformanceSummaryView,
            
            /// <summary>
            /// Enum QueueWorkitemPerformanceDetailView for "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "QUEUE_WORKITEM_PERFORMANCE_DETAIL_VIEW")]
            QueueWorkitemPerformanceDetailView,
            
            /// <summary>
            /// Enum EmailAgentPerformanceSummaryView for "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_SUMMARY_VIEW")]
            EmailAgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum EmailAgentPerformanceDetailView for "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_AGENT_PERFORMANCE_DETAIL_VIEW")]
            EmailAgentPerformanceDetailView,
            
            /// <summary>
            /// Enum MessagingAgentPerformanceSummaryView for "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_SUMMARY_VIEW")]
            MessagingAgentPerformanceSummaryView,
            
            /// <summary>
            /// Enum MessagingAgentPerformanceDetailView for "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_AGENT_PERFORMANCE_DETAIL_VIEW")]
            MessagingAgentPerformanceDetailView,
            
            /// <summary>
            /// Enum EmailQueuePerformanceSummaryView for "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            EmailQueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum EmailQueuePerformanceDetailView for "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "EMAIL_QUEUE_PERFORMANCE_DETAIL_VIEW")]
            EmailQueuePerformanceDetailView,
            
            /// <summary>
            /// Enum MessagingQueuePerformanceSummaryView for "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_SUMMARY_VIEW")]
            MessagingQueuePerformanceSummaryView,
            
            /// <summary>
            /// Enum MessagingQueuePerformanceDetailView for "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "MESSAGING_QUEUE_PERFORMANCE_DETAIL_VIEW")]
            MessagingQueuePerformanceDetailView,
            
            /// <summary>
            /// Enum SocialListeningView for "SOCIAL_LISTENING_VIEW"
            /// </summary>
            [EnumMember(Value = "SOCIAL_LISTENING_VIEW")]
            SocialListeningView,
            
            /// <summary>
            /// Enum SocialListeningPostsView for "SOCIAL_LISTENING_POSTS_VIEW"
            /// </summary>
            [EnumMember(Value = "SOCIAL_LISTENING_POSTS_VIEW")]
            SocialListeningPostsView,
            
            /// <summary>
            /// Enum AgentPerformanceTimelineDetailView for "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_PERFORMANCE_TIMELINE_DETAIL_VIEW")]
            AgentPerformanceTimelineDetailView,
            
            /// <summary>
            /// Enum DashboardSlideshows for "DASHBOARD_SLIDESHOWS"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_SLIDESHOWS")]
            DashboardSlideshows,
            
            /// <summary>
            /// Enum DashboardSlideshowsDetail for "DASHBOARD_SLIDESHOWS_DETAIL"
            /// </summary>
            [EnumMember(Value = "DASHBOARD_SLIDESHOWS_DETAIL")]
            DashboardSlideshowsDetail,
            
            /// <summary>
            /// Enum AgentCopilotPerformanceView for "AGENT_COPILOT_PERFORMANCE_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_COPILOT_PERFORMANCE_VIEW")]
            AgentCopilotPerformanceView,
            
            /// <summary>
            /// Enum AgentAssignedEvaluationMeView for "AGENT_ASSIGNED_EVALUATION_ME_VIEW"
            /// </summary>
            [EnumMember(Value = "AGENT_ASSIGNED_EVALUATION_ME_VIEW")]
            AgentAssignedEvaluationMeView
        }
        /// <summary>
        /// The view type of the export metadata
        /// </summary>
        /// <value>The view type of the export metadata</value>
        [DataMember(Name="viewType", EmitDefaultValue=false)]
        public ViewTypeEnum? ViewType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingExportMetadataJobResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ViewType">The view type of the export metadata.</param>
        /// <param name="DateLimitations">The date limitations of the export metadata.</param>
        /// <param name="RequiredFilters">The list of required filters for the export metadata.</param>
        /// <param name="SupportedFilters">The list of supported filters for the export metadata.</param>
        /// <param name="RequiredColumnIds">The list of required column ids for the export metadata.</param>
        /// <param name="DependentColumnIds">The list of dependent column ids for the export metadata.</param>
        /// <param name="AvailableColumnIds">The list of available column ids for the export metadata.</param>
        public ReportingExportMetadataJobResponse(string Name = null, ViewTypeEnum? ViewType = null, string DateLimitations = null, List<string> RequiredFilters = null, List<string> SupportedFilters = null, List<string> RequiredColumnIds = null, Dictionary<string, List<string>> DependentColumnIds = null, List<string> AvailableColumnIds = null)
        {
            this.Name = Name;
            this.ViewType = ViewType;
            this.DateLimitations = DateLimitations;
            this.RequiredFilters = RequiredFilters;
            this.SupportedFilters = SupportedFilters;
            this.RequiredColumnIds = RequiredColumnIds;
            this.DependentColumnIds = DependentColumnIds;
            this.AvailableColumnIds = AvailableColumnIds;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }





        /// <summary>
        /// The date limitations of the export metadata
        /// </summary>
        /// <value>The date limitations of the export metadata</value>
        [DataMember(Name="dateLimitations", EmitDefaultValue=false)]
        public string DateLimitations { get; set; }



        /// <summary>
        /// The list of required filters for the export metadata
        /// </summary>
        /// <value>The list of required filters for the export metadata</value>
        [DataMember(Name="requiredFilters", EmitDefaultValue=false)]
        public List<string> RequiredFilters { get; set; }



        /// <summary>
        /// The list of supported filters for the export metadata
        /// </summary>
        /// <value>The list of supported filters for the export metadata</value>
        [DataMember(Name="supportedFilters", EmitDefaultValue=false)]
        public List<string> SupportedFilters { get; set; }



        /// <summary>
        /// The list of required column ids for the export metadata
        /// </summary>
        /// <value>The list of required column ids for the export metadata</value>
        [DataMember(Name="requiredColumnIds", EmitDefaultValue=false)]
        public List<string> RequiredColumnIds { get; set; }



        /// <summary>
        /// The list of dependent column ids for the export metadata
        /// </summary>
        /// <value>The list of dependent column ids for the export metadata</value>
        [DataMember(Name="dependentColumnIds", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> DependentColumnIds { get; set; }



        /// <summary>
        /// The list of available column ids for the export metadata
        /// </summary>
        /// <value>The list of available column ids for the export metadata</value>
        [DataMember(Name="availableColumnIds", EmitDefaultValue=false)]
        public List<string> AvailableColumnIds { get; set; }



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
            sb.Append("class ReportingExportMetadataJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ViewType: ").Append(ViewType).Append("\n");
            sb.Append("  DateLimitations: ").Append(DateLimitations).Append("\n");
            sb.Append("  RequiredFilters: ").Append(RequiredFilters).Append("\n");
            sb.Append("  SupportedFilters: ").Append(SupportedFilters).Append("\n");
            sb.Append("  RequiredColumnIds: ").Append(RequiredColumnIds).Append("\n");
            sb.Append("  DependentColumnIds: ").Append(DependentColumnIds).Append("\n");
            sb.Append("  AvailableColumnIds: ").Append(AvailableColumnIds).Append("\n");
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
            return this.Equals(obj as ReportingExportMetadataJobResponse);
        }

        /// <summary>
        /// Returns true if ReportingExportMetadataJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingExportMetadataJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingExportMetadataJobResponse other)
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
                    this.ViewType == other.ViewType ||
                    this.ViewType != null &&
                    this.ViewType.Equals(other.ViewType)
                ) &&
                (
                    this.DateLimitations == other.DateLimitations ||
                    this.DateLimitations != null &&
                    this.DateLimitations.Equals(other.DateLimitations)
                ) &&
                (
                    this.RequiredFilters == other.RequiredFilters ||
                    this.RequiredFilters != null &&
                    this.RequiredFilters.SequenceEqual(other.RequiredFilters)
                ) &&
                (
                    this.SupportedFilters == other.SupportedFilters ||
                    this.SupportedFilters != null &&
                    this.SupportedFilters.SequenceEqual(other.SupportedFilters)
                ) &&
                (
                    this.RequiredColumnIds == other.RequiredColumnIds ||
                    this.RequiredColumnIds != null &&
                    this.RequiredColumnIds.SequenceEqual(other.RequiredColumnIds)
                ) &&
                (
                    this.DependentColumnIds == other.DependentColumnIds ||
                    this.DependentColumnIds != null &&
                    this.DependentColumnIds.SequenceEqual(other.DependentColumnIds)
                ) &&
                (
                    this.AvailableColumnIds == other.AvailableColumnIds ||
                    this.AvailableColumnIds != null &&
                    this.AvailableColumnIds.SequenceEqual(other.AvailableColumnIds)
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

                if (this.ViewType != null)
                    hash = hash * 59 + this.ViewType.GetHashCode();

                if (this.DateLimitations != null)
                    hash = hash * 59 + this.DateLimitations.GetHashCode();

                if (this.RequiredFilters != null)
                    hash = hash * 59 + this.RequiredFilters.GetHashCode();

                if (this.SupportedFilters != null)
                    hash = hash * 59 + this.SupportedFilters.GetHashCode();

                if (this.RequiredColumnIds != null)
                    hash = hash * 59 + this.RequiredColumnIds.GetHashCode();

                if (this.DependentColumnIds != null)
                    hash = hash * 59 + this.DependentColumnIds.GetHashCode();

                if (this.AvailableColumnIds != null)
                    hash = hash * 59 + this.AvailableColumnIds.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
