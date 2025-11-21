/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MediaTailor
{

    /// <summary>
    /// Constants used for properties of type AccessType.
    /// </summary>
    public class AccessType : ConstantClass
    {

        /// <summary>
        /// Constant AUTODETECT_SIGV4 for AccessType
        /// </summary>
        public static readonly AccessType AUTODETECT_SIGV4 = new AccessType("AUTODETECT_SIGV4");
        /// <summary>
        /// Constant S3_SIGV4 for AccessType
        /// </summary>
        public static readonly AccessType S3_SIGV4 = new AccessType("S3_SIGV4");
        /// <summary>
        /// Constant SECRETS_MANAGER_ACCESS_TOKEN for AccessType
        /// </summary>
        public static readonly AccessType SECRETS_MANAGER_ACCESS_TOKEN = new AccessType("SECRETS_MANAGER_ACCESS_TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessType FindValue(string value)
        {
            return FindValue<AccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdMarkupType.
    /// </summary>
    public class AdMarkupType : ConstantClass
    {

        /// <summary>
        /// Constant DATERANGE for AdMarkupType
        /// </summary>
        public static readonly AdMarkupType DATERANGE = new AdMarkupType("DATERANGE");
        /// <summary>
        /// Constant SCTE35_ENHANCED for AdMarkupType
        /// </summary>
        public static readonly AdMarkupType SCTE35_ENHANCED = new AdMarkupType("SCTE35_ENHANCED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdMarkupType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdMarkupType FindValue(string value)
        {
            return FindValue<AdMarkupType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdMarkupType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdsInteractionExcludeEventType.
    /// </summary>
    public class AdsInteractionExcludeEventType : ConstantClass
    {

        /// <summary>
        /// Constant AD_MARKER_FOUND for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType AD_MARKER_FOUND = new AdsInteractionExcludeEventType("AD_MARKER_FOUND");
        /// <summary>
        /// Constant BEACON_FIRED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType BEACON_FIRED = new AdsInteractionExcludeEventType("BEACON_FIRED");
        /// <summary>
        /// Constant EMPTY_VAST_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType EMPTY_VAST_RESPONSE = new AdsInteractionExcludeEventType("EMPTY_VAST_RESPONSE");
        /// <summary>
        /// Constant EMPTY_VMAP_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType EMPTY_VMAP_RESPONSE = new AdsInteractionExcludeEventType("EMPTY_VMAP_RESPONSE");
        /// <summary>
        /// Constant ERROR_ADS_INVALID_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_ADS_INVALID_RESPONSE = new AdsInteractionExcludeEventType("ERROR_ADS_INVALID_RESPONSE");
        /// <summary>
        /// Constant ERROR_ADS_IO for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_ADS_IO = new AdsInteractionExcludeEventType("ERROR_ADS_IO");
        /// <summary>
        /// Constant ERROR_ADS_RESPONSE_PARSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_ADS_RESPONSE_PARSE = new AdsInteractionExcludeEventType("ERROR_ADS_RESPONSE_PARSE");
        /// <summary>
        /// Constant ERROR_ADS_RESPONSE_UNKNOWN_ROOT_ELEMENT for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_ADS_RESPONSE_UNKNOWN_ROOT_ELEMENT = new AdsInteractionExcludeEventType("ERROR_ADS_RESPONSE_UNKNOWN_ROOT_ELEMENT");
        /// <summary>
        /// Constant ERROR_ADS_TIMEOUT for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_ADS_TIMEOUT = new AdsInteractionExcludeEventType("ERROR_ADS_TIMEOUT");
        /// <summary>
        /// Constant ERROR_DISALLOWED_HOST for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_DISALLOWED_HOST = new AdsInteractionExcludeEventType("ERROR_DISALLOWED_HOST");
        /// <summary>
        /// Constant ERROR_FIRING_BEACON_FAILED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_FIRING_BEACON_FAILED = new AdsInteractionExcludeEventType("ERROR_FIRING_BEACON_FAILED");
        /// <summary>
        /// Constant ERROR_PERSONALIZATION_DISABLED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_PERSONALIZATION_DISABLED = new AdsInteractionExcludeEventType("ERROR_PERSONALIZATION_DISABLED");
        /// <summary>
        /// Constant ERROR_UNKNOWN for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_UNKNOWN = new AdsInteractionExcludeEventType("ERROR_UNKNOWN");
        /// <summary>
        /// Constant ERROR_UNKNOWN_HOST for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_UNKNOWN_HOST = new AdsInteractionExcludeEventType("ERROR_UNKNOWN_HOST");
        /// <summary>
        /// Constant ERROR_VAST_INVALID_MEDIA_FILE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_INVALID_MEDIA_FILE = new AdsInteractionExcludeEventType("ERROR_VAST_INVALID_MEDIA_FILE");
        /// <summary>
        /// Constant ERROR_VAST_INVALID_VAST_AD_TAG_URI for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_INVALID_VAST_AD_TAG_URI = new AdsInteractionExcludeEventType("ERROR_VAST_INVALID_VAST_AD_TAG_URI");
        /// <summary>
        /// Constant ERROR_VAST_MISSING_CREATIVES for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MISSING_CREATIVES = new AdsInteractionExcludeEventType("ERROR_VAST_MISSING_CREATIVES");
        /// <summary>
        /// Constant ERROR_VAST_MISSING_IMPRESSION for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MISSING_IMPRESSION = new AdsInteractionExcludeEventType("ERROR_VAST_MISSING_IMPRESSION");
        /// <summary>
        /// Constant ERROR_VAST_MISSING_MEDIAFILES for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MISSING_MEDIAFILES = new AdsInteractionExcludeEventType("ERROR_VAST_MISSING_MEDIAFILES");
        /// <summary>
        /// Constant ERROR_VAST_MISSING_OVERLAYS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MISSING_OVERLAYS = new AdsInteractionExcludeEventType("ERROR_VAST_MISSING_OVERLAYS");
        /// <summary>
        /// Constant ERROR_VAST_MULTIPLE_LINEAR for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MULTIPLE_LINEAR = new AdsInteractionExcludeEventType("ERROR_VAST_MULTIPLE_LINEAR");
        /// <summary>
        /// Constant ERROR_VAST_MULTIPLE_TRACKING_EVENTS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_MULTIPLE_TRACKING_EVENTS = new AdsInteractionExcludeEventType("ERROR_VAST_MULTIPLE_TRACKING_EVENTS");
        /// <summary>
        /// Constant ERROR_VAST_REDIRECT_EMPTY_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_REDIRECT_EMPTY_RESPONSE = new AdsInteractionExcludeEventType("ERROR_VAST_REDIRECT_EMPTY_RESPONSE");
        /// <summary>
        /// Constant ERROR_VAST_REDIRECT_FAILED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_REDIRECT_FAILED = new AdsInteractionExcludeEventType("ERROR_VAST_REDIRECT_FAILED");
        /// <summary>
        /// Constant ERROR_VAST_REDIRECT_MULTIPLE_VAST for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType ERROR_VAST_REDIRECT_MULTIPLE_VAST = new AdsInteractionExcludeEventType("ERROR_VAST_REDIRECT_MULTIPLE_VAST");
        /// <summary>
        /// Constant FILLED_AVAIL for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType FILLED_AVAIL = new AdsInteractionExcludeEventType("FILLED_AVAIL");
        /// <summary>
        /// Constant FILLED_OVERLAY_AVAIL for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType FILLED_OVERLAY_AVAIL = new AdsInteractionExcludeEventType("FILLED_OVERLAY_AVAIL");
        /// <summary>
        /// Constant INTERSTITIAL_VOD_FAILURE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType INTERSTITIAL_VOD_FAILURE = new AdsInteractionExcludeEventType("INTERSTITIAL_VOD_FAILURE");
        /// <summary>
        /// Constant INTERSTITIAL_VOD_SUCCESS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType INTERSTITIAL_VOD_SUCCESS = new AdsInteractionExcludeEventType("INTERSTITIAL_VOD_SUCCESS");
        /// <summary>
        /// Constant MAKING_ADS_REQUEST for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType MAKING_ADS_REQUEST = new AdsInteractionExcludeEventType("MAKING_ADS_REQUEST");
        /// <summary>
        /// Constant MODIFIED_TARGET_URL for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType MODIFIED_TARGET_URL = new AdsInteractionExcludeEventType("MODIFIED_TARGET_URL");
        /// <summary>
        /// Constant NON_AD_MARKER_FOUND for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType NON_AD_MARKER_FOUND = new AdsInteractionExcludeEventType("NON_AD_MARKER_FOUND");
        /// <summary>
        /// Constant REDIRECTED_VAST_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType REDIRECTED_VAST_RESPONSE = new AdsInteractionExcludeEventType("REDIRECTED_VAST_RESPONSE");
        /// <summary>
        /// Constant VAST_REDIRECT for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType VAST_REDIRECT = new AdsInteractionExcludeEventType("VAST_REDIRECT");
        /// <summary>
        /// Constant VAST_RESPONSE for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType VAST_RESPONSE = new AdsInteractionExcludeEventType("VAST_RESPONSE");
        /// <summary>
        /// Constant VOD_TIME_BASED_AVAIL_PLAN_SUCCESS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType VOD_TIME_BASED_AVAIL_PLAN_SUCCESS = new AdsInteractionExcludeEventType("VOD_TIME_BASED_AVAIL_PLAN_SUCCESS");
        /// <summary>
        /// Constant VOD_TIME_BASED_AVAIL_PLAN_VAST_RESPONSE_FOR_OFFSET for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType VOD_TIME_BASED_AVAIL_PLAN_VAST_RESPONSE_FOR_OFFSET = new AdsInteractionExcludeEventType("VOD_TIME_BASED_AVAIL_PLAN_VAST_RESPONSE_FOR_OFFSET");
        /// <summary>
        /// Constant VOD_TIME_BASED_AVAIL_PLAN_WARNING_NO_ADVERTISEMENTS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType VOD_TIME_BASED_AVAIL_PLAN_WARNING_NO_ADVERTISEMENTS = new AdsInteractionExcludeEventType("VOD_TIME_BASED_AVAIL_PLAN_WARNING_NO_ADVERTISEMENTS");
        /// <summary>
        /// Constant WARNING_NO_ADVERTISEMENTS for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType WARNING_NO_ADVERTISEMENTS = new AdsInteractionExcludeEventType("WARNING_NO_ADVERTISEMENTS");
        /// <summary>
        /// Constant WARNING_URL_VARIABLE_SUBSTITUTION_FAILED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType WARNING_URL_VARIABLE_SUBSTITUTION_FAILED = new AdsInteractionExcludeEventType("WARNING_URL_VARIABLE_SUBSTITUTION_FAILED");
        /// <summary>
        /// Constant WARNING_VPAID_AD_DROPPED for AdsInteractionExcludeEventType
        /// </summary>
        public static readonly AdsInteractionExcludeEventType WARNING_VPAID_AD_DROPPED = new AdsInteractionExcludeEventType("WARNING_VPAID_AD_DROPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdsInteractionExcludeEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdsInteractionExcludeEventType FindValue(string value)
        {
            return FindValue<AdsInteractionExcludeEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdsInteractionExcludeEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdsInteractionPublishOptInEventType.
    /// </summary>
    public class AdsInteractionPublishOptInEventType : ConstantClass
    {

        /// <summary>
        /// Constant RAW_ADS_RESPONSE for AdsInteractionPublishOptInEventType
        /// </summary>
        public static readonly AdsInteractionPublishOptInEventType RAW_ADS_RESPONSE = new AdsInteractionPublishOptInEventType("RAW_ADS_RESPONSE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdsInteractionPublishOptInEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdsInteractionPublishOptInEventType FindValue(string value)
        {
            return FindValue<AdsInteractionPublishOptInEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdsInteractionPublishOptInEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlertCategory.
    /// </summary>
    public class AlertCategory : ConstantClass
    {

        /// <summary>
        /// Constant INFO for AlertCategory
        /// </summary>
        public static readonly AlertCategory INFO = new AlertCategory("INFO");
        /// <summary>
        /// Constant PLAYBACK_WARNING for AlertCategory
        /// </summary>
        public static readonly AlertCategory PLAYBACK_WARNING = new AlertCategory("PLAYBACK_WARNING");
        /// <summary>
        /// Constant SCHEDULING_ERROR for AlertCategory
        /// </summary>
        public static readonly AlertCategory SCHEDULING_ERROR = new AlertCategory("SCHEDULING_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlertCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlertCategory FindValue(string value)
        {
            return FindValue<AlertCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlertCategory(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChannelState.
    /// </summary>
    public class ChannelState : ConstantClass
    {

        /// <summary>
        /// Constant RUNNING for ChannelState
        /// </summary>
        public static readonly ChannelState RUNNING = new ChannelState("RUNNING");
        /// <summary>
        /// Constant STOPPED for ChannelState
        /// </summary>
        public static readonly ChannelState STOPPED = new ChannelState("STOPPED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChannelState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChannelState FindValue(string value)
        {
            return FindValue<ChannelState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChannelState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FillPolicy.
    /// </summary>
    public class FillPolicy : ConstantClass
    {

        /// <summary>
        /// Constant FULL_AVAIL_ONLY for FillPolicy
        /// </summary>
        public static readonly FillPolicy FULL_AVAIL_ONLY = new FillPolicy("FULL_AVAIL_ONLY");
        /// <summary>
        /// Constant PARTIAL_AVAIL for FillPolicy
        /// </summary>
        public static readonly FillPolicy PARTIAL_AVAIL = new FillPolicy("PARTIAL_AVAIL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FillPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FillPolicy FindValue(string value)
        {
            return FindValue<FillPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FillPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsertionMode.
    /// </summary>
    public class InsertionMode : ConstantClass
    {

        /// <summary>
        /// Constant PLAYER_SELECT for InsertionMode
        /// </summary>
        public static readonly InsertionMode PLAYER_SELECT = new InsertionMode("PLAYER_SELECT");
        /// <summary>
        /// Constant STITCHED_ONLY for InsertionMode
        /// </summary>
        public static readonly InsertionMode STITCHED_ONLY = new InsertionMode("STITCHED_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsertionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsertionMode FindValue(string value)
        {
            return FindValue<InsertionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsertionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListPrefetchScheduleType.
    /// </summary>
    public class ListPrefetchScheduleType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for ListPrefetchScheduleType
        /// </summary>
        public static readonly ListPrefetchScheduleType ALL = new ListPrefetchScheduleType("ALL");
        /// <summary>
        /// Constant RECURRING for ListPrefetchScheduleType
        /// </summary>
        public static readonly ListPrefetchScheduleType RECURRING = new ListPrefetchScheduleType("RECURRING");
        /// <summary>
        /// Constant SINGLE for ListPrefetchScheduleType
        /// </summary>
        public static readonly ListPrefetchScheduleType SINGLE = new ListPrefetchScheduleType("SINGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListPrefetchScheduleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListPrefetchScheduleType FindValue(string value)
        {
            return FindValue<ListPrefetchScheduleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListPrefetchScheduleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LoggingStrategy.
    /// </summary>
    public class LoggingStrategy : ConstantClass
    {

        /// <summary>
        /// Constant LEGACY_CLOUDWATCH for LoggingStrategy
        /// </summary>
        public static readonly LoggingStrategy LEGACY_CLOUDWATCH = new LoggingStrategy("LEGACY_CLOUDWATCH");
        /// <summary>
        /// Constant VENDED_LOGS for LoggingStrategy
        /// </summary>
        public static readonly LoggingStrategy VENDED_LOGS = new LoggingStrategy("VENDED_LOGS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LoggingStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LoggingStrategy FindValue(string value)
        {
            return FindValue<LoggingStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LoggingStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant AS_RUN for LogType
        /// </summary>
        public static readonly LogType AS_RUN = new LogType("AS_RUN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ManifestServiceExcludeEventType.
    /// </summary>
    public class ManifestServiceExcludeEventType : ConstantClass
    {

        /// <summary>
        /// Constant CONFIG_SECURITY_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType CONFIG_SECURITY_ERROR = new ManifestServiceExcludeEventType("CONFIG_SECURITY_ERROR");
        /// <summary>
        /// Constant CONFIG_SYNTAX_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType CONFIG_SYNTAX_ERROR = new ManifestServiceExcludeEventType("CONFIG_SYNTAX_ERROR");
        /// <summary>
        /// Constant CONNECTION_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType CONNECTION_ERROR = new ManifestServiceExcludeEventType("CONNECTION_ERROR");
        /// <summary>
        /// Constant ERROR_ADS_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_ADS_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_ADS_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_BUMPER_END_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_BUMPER_END_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_BUMPER_END_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_BUMPER_START_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_BUMPER_START_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_BUMPER_START_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_CDN_AD_SEGMENT_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_CDN_AD_SEGMENT_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_CDN_AD_SEGMENT_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_CDN_CONTENT_SEGMENT_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_CDN_CONTENT_SEGMENT_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_CDN_CONTENT_SEGMENT_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_LIVE_PRE_ROLL_ADS_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_LIVE_PRE_ROLL_ADS_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_LIVE_PRE_ROLL_ADS_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_ORIGIN_PREFIX_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_ORIGIN_PREFIX_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_ORIGIN_PREFIX_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_PROFILE_NAME_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_PROFILE_NAME_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_PROFILE_NAME_INTERPOLATION");
        /// <summary>
        /// Constant ERROR_SLATE_AD_URL_INTERPOLATION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ERROR_SLATE_AD_URL_INTERPOLATION = new ManifestServiceExcludeEventType("ERROR_SLATE_AD_URL_INTERPOLATION");
        /// <summary>
        /// Constant GENERATED_MANIFEST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType GENERATED_MANIFEST = new ManifestServiceExcludeEventType("GENERATED_MANIFEST");
        /// <summary>
        /// Constant HOST_DISALLOWED for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType HOST_DISALLOWED = new ManifestServiceExcludeEventType("HOST_DISALLOWED");
        /// <summary>
        /// Constant INCOMPATIBLE_HLS_VERSION for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType INCOMPATIBLE_HLS_VERSION = new ManifestServiceExcludeEventType("INCOMPATIBLE_HLS_VERSION");
        /// <summary>
        /// Constant INVALID_SINGLE_PERIOD_DASH_MANIFEST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType INVALID_SINGLE_PERIOD_DASH_MANIFEST = new ManifestServiceExcludeEventType("INVALID_SINGLE_PERIOD_DASH_MANIFEST");
        /// <summary>
        /// Constant IO_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType IO_ERROR = new ManifestServiceExcludeEventType("IO_ERROR");
        /// <summary>
        /// Constant LAST_PERIOD_MISSING_AUDIO for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType LAST_PERIOD_MISSING_AUDIO = new ManifestServiceExcludeEventType("LAST_PERIOD_MISSING_AUDIO");
        /// <summary>
        /// Constant LAST_PERIOD_MISSING_AUDIO_WARNING for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType LAST_PERIOD_MISSING_AUDIO_WARNING = new ManifestServiceExcludeEventType("LAST_PERIOD_MISSING_AUDIO_WARNING");
        /// <summary>
        /// Constant MANIFEST_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType MANIFEST_ERROR = new ManifestServiceExcludeEventType("MANIFEST_ERROR");
        /// <summary>
        /// Constant NO_MASTER_OR_MEDIA_PLAYLIST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType NO_MASTER_OR_MEDIA_PLAYLIST = new ManifestServiceExcludeEventType("NO_MASTER_OR_MEDIA_PLAYLIST");
        /// <summary>
        /// Constant NO_MASTER_PLAYLIST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType NO_MASTER_PLAYLIST = new ManifestServiceExcludeEventType("NO_MASTER_PLAYLIST");
        /// <summary>
        /// Constant NO_MEDIA_PLAYLIST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType NO_MEDIA_PLAYLIST = new ManifestServiceExcludeEventType("NO_MEDIA_PLAYLIST");
        /// <summary>
        /// Constant ORIGIN_MANIFEST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType ORIGIN_MANIFEST = new ManifestServiceExcludeEventType("ORIGIN_MANIFEST");
        /// <summary>
        /// Constant PARSING_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType PARSING_ERROR = new ManifestServiceExcludeEventType("PARSING_ERROR");
        /// <summary>
        /// Constant SCTE35_PARSING_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType SCTE35_PARSING_ERROR = new ManifestServiceExcludeEventType("SCTE35_PARSING_ERROR");
        /// <summary>
        /// Constant SESSION_INITIALIZED for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType SESSION_INITIALIZED = new ManifestServiceExcludeEventType("SESSION_INITIALIZED");
        /// <summary>
        /// Constant TIMEOUT_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType TIMEOUT_ERROR = new ManifestServiceExcludeEventType("TIMEOUT_ERROR");
        /// <summary>
        /// Constant TRACKING_RESPONSE for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType TRACKING_RESPONSE = new ManifestServiceExcludeEventType("TRACKING_RESPONSE");
        /// <summary>
        /// Constant UNKNOWN_ERROR for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType UNKNOWN_ERROR = new ManifestServiceExcludeEventType("UNKNOWN_ERROR");
        /// <summary>
        /// Constant UNKNOWN_HOST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType UNKNOWN_HOST = new ManifestServiceExcludeEventType("UNKNOWN_HOST");
        /// <summary>
        /// Constant UNSUPPORTED_SINGLE_PERIOD_DASH_MANIFEST for ManifestServiceExcludeEventType
        /// </summary>
        public static readonly ManifestServiceExcludeEventType UNSUPPORTED_SINGLE_PERIOD_DASH_MANIFEST = new ManifestServiceExcludeEventType("UNSUPPORTED_SINGLE_PERIOD_DASH_MANIFEST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ManifestServiceExcludeEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ManifestServiceExcludeEventType FindValue(string value)
        {
            return FindValue<ManifestServiceExcludeEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ManifestServiceExcludeEventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MessageType.
    /// </summary>
    public class MessageType : ConstantClass
    {

        /// <summary>
        /// Constant SPLICE_INSERT for MessageType
        /// </summary>
        public static readonly MessageType SPLICE_INSERT = new MessageType("SPLICE_INSERT");
        /// <summary>
        /// Constant TIME_SIGNAL for MessageType
        /// </summary>
        public static readonly MessageType TIME_SIGNAL = new MessageType("TIME_SIGNAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MessageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MessageType FindValue(string value)
        {
            return FindValue<MessageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MessageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Mode.
    /// </summary>
    public class Mode : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_LIVE_EDGE for Mode
        /// </summary>
        public static readonly Mode AFTER_LIVE_EDGE = new Mode("AFTER_LIVE_EDGE");
        /// <summary>
        /// Constant BEHIND_LIVE_EDGE for Mode
        /// </summary>
        public static readonly Mode BEHIND_LIVE_EDGE = new Mode("BEHIND_LIVE_EDGE");
        /// <summary>
        /// Constant OFF for Mode
        /// </summary>
        public static readonly Mode OFF = new Mode("OFF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Mode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Mode FindValue(string value)
        {
            return FindValue<Mode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Mode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant EQUALS for Operator
        /// </summary>
        public static readonly Operator EQUALS = new Operator("EQUALS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OriginManifestType.
    /// </summary>
    public class OriginManifestType : ConstantClass
    {

        /// <summary>
        /// Constant MULTI_PERIOD for OriginManifestType
        /// </summary>
        public static readonly OriginManifestType MULTI_PERIOD = new OriginManifestType("MULTI_PERIOD");
        /// <summary>
        /// Constant SINGLE_PERIOD for OriginManifestType
        /// </summary>
        public static readonly OriginManifestType SINGLE_PERIOD = new OriginManifestType("SINGLE_PERIOD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OriginManifestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OriginManifestType FindValue(string value)
        {
            return FindValue<OriginManifestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OriginManifestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PlaybackMode.
    /// </summary>
    public class PlaybackMode : ConstantClass
    {

        /// <summary>
        /// Constant LINEAR for PlaybackMode
        /// </summary>
        public static readonly PlaybackMode LINEAR = new PlaybackMode("LINEAR");
        /// <summary>
        /// Constant LOOP for PlaybackMode
        /// </summary>
        public static readonly PlaybackMode LOOP = new PlaybackMode("LOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PlaybackMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PlaybackMode FindValue(string value)
        {
            return FindValue<PlaybackMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PlaybackMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrefetchScheduleType.
    /// </summary>
    public class PrefetchScheduleType : ConstantClass
    {

        /// <summary>
        /// Constant RECURRING for PrefetchScheduleType
        /// </summary>
        public static readonly PrefetchScheduleType RECURRING = new PrefetchScheduleType("RECURRING");
        /// <summary>
        /// Constant SINGLE for PrefetchScheduleType
        /// </summary>
        public static readonly PrefetchScheduleType SINGLE = new PrefetchScheduleType("SINGLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrefetchScheduleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrefetchScheduleType FindValue(string value)
        {
            return FindValue<PrefetchScheduleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrefetchScheduleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelativePosition.
    /// </summary>
    public class RelativePosition : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_PROGRAM for RelativePosition
        /// </summary>
        public static readonly RelativePosition AFTER_PROGRAM = new RelativePosition("AFTER_PROGRAM");
        /// <summary>
        /// Constant BEFORE_PROGRAM for RelativePosition
        /// </summary>
        public static readonly RelativePosition BEFORE_PROGRAM = new RelativePosition("BEFORE_PROGRAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelativePosition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelativePosition FindValue(string value)
        {
            return FindValue<RelativePosition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelativePosition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScheduleEntryType.
    /// </summary>
    public class ScheduleEntryType : ConstantClass
    {

        /// <summary>
        /// Constant ALTERNATE_MEDIA for ScheduleEntryType
        /// </summary>
        public static readonly ScheduleEntryType ALTERNATE_MEDIA = new ScheduleEntryType("ALTERNATE_MEDIA");
        /// <summary>
        /// Constant FILLER_SLATE for ScheduleEntryType
        /// </summary>
        public static readonly ScheduleEntryType FILLER_SLATE = new ScheduleEntryType("FILLER_SLATE");
        /// <summary>
        /// Constant PROGRAM for ScheduleEntryType
        /// </summary>
        public static readonly ScheduleEntryType PROGRAM = new ScheduleEntryType("PROGRAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScheduleEntryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScheduleEntryType FindValue(string value)
        {
            return FindValue<ScheduleEntryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScheduleEntryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StreamingMediaFileConditioning.
    /// </summary>
    public class StreamingMediaFileConditioning : ConstantClass
    {

        /// <summary>
        /// Constant NONE for StreamingMediaFileConditioning
        /// </summary>
        public static readonly StreamingMediaFileConditioning NONE = new StreamingMediaFileConditioning("NONE");
        /// <summary>
        /// Constant TRANSCODE for StreamingMediaFileConditioning
        /// </summary>
        public static readonly StreamingMediaFileConditioning TRANSCODE = new StreamingMediaFileConditioning("TRANSCODE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StreamingMediaFileConditioning(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StreamingMediaFileConditioning FindValue(string value)
        {
            return FindValue<StreamingMediaFileConditioning>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StreamingMediaFileConditioning(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tier.
    /// </summary>
    public class Tier : ConstantClass
    {

        /// <summary>
        /// Constant BASIC for Tier
        /// </summary>
        public static readonly Tier BASIC = new Tier("BASIC");
        /// <summary>
        /// Constant STANDARD for Tier
        /// </summary>
        public static readonly Tier STANDARD = new Tier("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tier FindValue(string value)
        {
            return FindValue<Tier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrafficShapingType.
    /// </summary>
    public class TrafficShapingType : ConstantClass
    {

        /// <summary>
        /// Constant RETRIEVAL_WINDOW for TrafficShapingType
        /// </summary>
        public static readonly TrafficShapingType RETRIEVAL_WINDOW = new TrafficShapingType("RETRIEVAL_WINDOW");
        /// <summary>
        /// Constant TPS for TrafficShapingType
        /// </summary>
        public static readonly TrafficShapingType TPS = new TrafficShapingType("TPS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrafficShapingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrafficShapingType FindValue(string value)
        {
            return FindValue<TrafficShapingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrafficShapingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant DASH for Type
        /// </summary>
        public static readonly Type DASH = new Type("DASH");
        /// <summary>
        /// Constant HLS for Type
        /// </summary>
        public static readonly Type HLS = new Type("HLS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}