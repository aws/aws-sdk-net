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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Includes the alarm's tags in the notifications that the alarm sends to Amazon SNS
    /// topics and Lambda functions. The tags are also included in the alarm's state-change
    /// events in Amazon EventBridge. Other types of alarm actions don't receive the tags.
    /// 
    ///  
    /// <para>
    /// By default, the alarm's tags aren't included.
    /// </para>
    ///  
    /// <para>
    /// Use this to route or filter notifications and events by tag, such as by team or environment.
    /// You can also use it to read the alarm's tags without looking them up separately.
    /// </para>
    ///  
    /// <para>
    /// To limit which tags are included, specify either <c>IncludedTagKeys</c> or <c>ExcludedTagKeys</c>.
    /// You can't specify both. If you specify neither, all of the alarm's tags are included.
    /// This includes tags that you add to the alarm later.
    /// </para>
    /// </summary>
    public partial class AlarmTagsPropagation
    {
        private bool? _enabled;
        private List<string> _excludedTagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includedTagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Set to <c>true</c> to include the alarm's tags. Set to <c>false</c> to stop including
        /// them.
        /// </para>
        ///  
        /// <para>
        /// When this is <c>true</c>, you must have the <c>cloudwatch:ListTagsForResource</c>
        /// permission on the alarm to create or update it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludedTagKeys. 
        /// <para>
        /// The tag keys to exclude. All of the alarm's tags except those with these keys are
        /// included.
        /// </para>
        ///  
        /// <para>
        /// You can specify 1 to 50 tag keys. Each tag key must be 1 to 128 characters long.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both <c>IncludedTagKeys</c> and <c>ExcludedTagKeys</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ExcludedTagKeys
        {
            get { return this._excludedTagKeys; }
            set { this._excludedTagKeys = value; }
        }

        // Check to see if ExcludedTagKeys property is set
        internal bool IsSetExcludedTagKeys()
        {
            return this._excludedTagKeys != null && (this._excludedTagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedTagKeys. 
        /// <para>
        /// The tag keys to include. Only the alarm's tags with these keys are included.
        /// </para>
        ///  
        /// <para>
        /// You can specify 1 to 50 tag keys. Each tag key must be 1 to 128 characters long.
        /// </para>
        ///  
        /// <para>
        /// You can't specify both <c>IncludedTagKeys</c> and <c>ExcludedTagKeys</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> IncludedTagKeys
        {
            get { return this._includedTagKeys; }
            set { this._includedTagKeys = value; }
        }

        // Check to see if IncludedTagKeys property is set
        internal bool IsSetIncludedTagKeys()
        {
            return this._includedTagKeys != null && (this._includedTagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}