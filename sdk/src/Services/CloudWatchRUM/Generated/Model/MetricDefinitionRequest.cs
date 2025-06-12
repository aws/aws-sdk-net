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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Use this structure to define one extended metric or custom metric that RUM will send
    /// to CloudWatch or CloudWatch Evidently. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-custom-and-extended-metrics.html">
    /// Custom metrics and extended metrics that you can send to CloudWatch and CloudWatch
    /// Evidently</a>.
    /// 
    ///  
    /// <para>
    /// This structure is validated differently for extended metrics and custom metrics. For
    /// extended metrics that are sent to the <c>AWS/RUM</c> namespace, the following validations
    /// apply:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>Namespace</c> parameter must be omitted or set to <c>AWS/RUM</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only certain combinations of values for <c>Name</c>, <c>ValueKey</c>, and <c>EventPattern</c>
    /// are valid. In addition to what is displayed in the following list, the <c>EventPattern</c>
    /// can also include information used by the <c>DimensionKeys</c> field.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If <c>Name</c> is <c>PerformanceNavigationDuration</c>, then <c>ValueKey</c>must be
    /// <c>event_details.duration</c> and the <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.performance_navigation_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>PerformanceResourceDuration</c>, then <c>ValueKey</c>must be
    /// <c>event_details.duration</c> and the <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.performance_resource_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>NavigationSatisfiedTransaction</c>, then <c>ValueKey</c>must
    /// be null and the <c>EventPattern</c> must include <c>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;",2000] }] } }</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>NavigationToleratedTransaction</c>, then <c>ValueKey</c>must
    /// be null and the <c>EventPattern</c> must include <c>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;=",2000,"&lt;"8000] }] } }</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>NavigationFrustratedTransaction</c>, then <c>ValueKey</c>must
    /// be null and the <c>EventPattern</c> must include <c>{ "event_type": ["com.amazon.rum.performance_navigation_event"],
    /// "event_details": { "duration": [{ "numeric": ["&gt;=",8000] }] } }</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>WebVitalsCumulativeLayoutShift</c>, then <c>ValueKey</c>must
    /// be <c>event_details.value</c> and the <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.cumulative_layout_shift_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>WebVitalsFirstInputDelay</c>, then <c>ValueKey</c>must be <c>event_details.value</c>
    /// and the <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.first_input_delay_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>WebVitalsLargestContentfulPaint</c>, then <c>ValueKey</c>must
    /// be <c>event_details.value</c> and the <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.largest_contentful_paint_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>JsErrorCount</c>, then <c>ValueKey</c>must be null and the <c>EventPattern</c>
    /// must include <c>{"event_type":["com.amazon.rum.js_error_event"]}</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>HttpErrorCount</c>, then <c>ValueKey</c>must be null and the
    /// <c>EventPattern</c> must include <c>{"event_type":["com.amazon.rum.http_event"]}</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>SessionCount</c>, then <c>ValueKey</c>must be null and the <c>EventPattern</c>
    /// must include <c>{"event_type":["com.amazon.rum.session_start_event"]}</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>PageViewCount</c>, then <c>ValueKey</c>must be null and the <c>EventPattern</c>
    /// must include <c>{"event_type":["com.amazon.rum.page_view_event"]}</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>Http4xxCount</c>, then <c>ValueKey</c>must be null and the <c>EventPattern</c>
    /// must include <c>{"event_type": ["com.amazon.rum.http_event"],"event_details":{"response":{"status":[{"numeric":["&gt;=",400,"&lt;",500]}]}}}
    /// }</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>Name</c> is <c>Http5xxCount</c>, then <c>ValueKey</c>must be null and the <c>EventPattern</c>
    /// must include <c>{"event_type": ["com.amazon.rum.http_event"],"event_details":{"response":{"status":[{"numeric":["&gt;=",500,"&lt;=",599]}]}}}
    /// }</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For custom metrics, the following validation rules apply:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The namespace can't be omitted and can't be <c>AWS/RUM</c>. You can use the <c>AWS/RUM</c>
    /// namespace only for extended metrics.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All dimensions listed in the <c>DimensionKeys</c> field must be present in the value
    /// of <c>EventPattern</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The values that you specify for <c>ValueKey</c>, <c>EventPattern</c>, and <c>DimensionKeys</c>
    /// must be fields in RUM events, so all first-level keys in these fields must be one
    /// of the keys in the list later in this section.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you set a value for <c>EventPattern</c>, it must be a JSON object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For every non-empty <c>event_details</c>, there must be a non-empty <c>event_type</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If <c>EventPattern</c> contains an <c>event_details</c> field, it must also contain
    /// an <c>event_type</c>. For every built-in <c>event_type</c> that you use, you must
    /// use a value for <c>event_details</c> that corresponds to that <c>event_type</c>. For
    /// information about event details that correspond to event types, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-datacollected.html#CloudWatch-RUM-datacollected-eventDetails">
    /// RUM event details</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In <c>EventPattern</c>, any JSON array must contain only one value.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Valid key values for first-level keys in the <c>ValueKey</c>, <c>EventPattern</c>,
    /// and <c>DimensionKeys</c> fields:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>account_id</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application_Id</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application_version</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application_name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>batch_id</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_details</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_id</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_interaction</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_timestamp</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_type</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>event_version</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>log_stream</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>metadata</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>sessionId</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>user_details</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>userId</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MetricDefinitionRequest
    {
        private Dictionary<string, string> _dimensionKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _eventPattern;
        private string _name;
        private string _awsNamespace;
        private string _unitLabel;
        private string _valueKey;

        /// <summary>
        /// Gets and sets the property DimensionKeys. 
        /// <para>
        /// Use this field only if you are sending the metric to CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// This field is a map of field paths to dimension names. It defines the dimensions to
        /// associate with this metric in CloudWatch. For extended metrics, valid values for the
        /// entries in this field are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"metadata.pageId": "PageId"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"metadata.browserName": "BrowserName"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"metadata.deviceType": "DeviceType"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"metadata.osName": "OSName"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"metadata.countryCode": "CountryCode"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"event_details.fileType": "FileType"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For both extended metrics and custom metrics, all dimensions listed in this field
        /// must also be included in <c>EventPattern</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=29)]
        public Dictionary<string, string> DimensionKeys
        {
            get { return this._dimensionKeys; }
            set { this._dimensionKeys = value; }
        }

        // Check to see if DimensionKeys property is set
        internal bool IsSetDimensionKeys()
        {
            return this._dimensionKeys != null && (this._dimensionKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The pattern that defines the metric, specified as a JSON object. RUM checks events
        /// that happen in a user's session against the pattern, and events that match the pattern
        /// are sent to the metric destination.
        /// </para>
        ///  
        /// <para>
        /// When you define extended metrics, the metric definition is not valid if <c>EventPattern</c>
        /// is omitted.
        /// </para>
        ///  
        /// <para>
        /// Example event patterns:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>'{ "event_type": ["com.amazon.rum.js_error_event"], "metadata": { "browserName":
        /// [ "Chrome", "Safari" ], } }'</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'{ "event_type": ["com.amazon.rum.performance_navigation_event"], "metadata":
        /// { "browserName": [ "Chrome", "Firefox" ] }, "event_details": { "duration": [{ "numeric":
        /// [ "&lt;", 2000 ] }] } }'</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>'{ "event_type": ["com.amazon.rum.performance_navigation_event"], "metadata":
        /// { "browserName": [ "Chrome", "Safari" ], "countryCode": [ "US" ] }, "event_details":
        /// { "duration": [{ "numeric": [ "&gt;=", 2000, "&lt;", 8000 ] }] } }'</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the metrics destination is <c>CloudWatch</c> and the event also matches a value
        /// in <c>DimensionKeys</c>, then the metric is published with the specified dimensions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4000)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the metric that is defined in this structure. For custom metrics, you
        /// can specify any name that you like. For extended metrics, valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PerformanceNavigationDuration</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PerformanceResourceDuration </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NavigationSatisfiedTransaction</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NavigationToleratedTransaction</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NavigationFrustratedTransaction</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WebVitalsCumulativeLayoutShift</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WebVitalsFirstInputDelay</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WebVitalsLargestContentfulPaint</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JsErrorCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HttpErrorCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SessionCount</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// If this structure is for a custom metric instead of an extended metrics, use this
        /// parameter to define the metric namespace for that custom metric. Do not specify this
        /// parameter if this structure is for an extended metric.
        /// </para>
        ///  
        /// <para>
        /// You cannot use any string that starts with <c>AWS/</c> for your namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=237)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property UnitLabel. 
        /// <para>
        /// The CloudWatch metric unit to use for this metric. If you omit this field, the metric
        /// is recorded with no unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UnitLabel
        {
            get { return this._unitLabel; }
            set { this._unitLabel = value; }
        }

        // Check to see if UnitLabel property is set
        internal bool IsSetUnitLabel()
        {
            return this._unitLabel != null;
        }

        /// <summary>
        /// Gets and sets the property ValueKey. 
        /// <para>
        /// The field within the event object that the metric value is sourced from.
        /// </para>
        ///  
        /// <para>
        /// If you omit this field, a hardcoded value of 1 is pushed as the metric value. This
        /// is useful if you want to count the number of events that the filter catches. 
        /// </para>
        ///  
        /// <para>
        /// If this metric is sent to CloudWatch Evidently, this field will be passed to Evidently
        /// raw. Evidently will handle data extraction from the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=280)]
        public string ValueKey
        {
            get { return this._valueKey; }
            set { this._valueKey = value; }
        }

        // Check to see if ValueKey property is set
        internal bool IsSetValueKey()
        {
            return this._valueKey != null;
        }

    }
}