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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that overrides settings for a single email sending request. An override
    /// applies only to the message or messages in the request that contains it. It doesn't
    /// change your account-level settings, and it doesn't change the configuration set that
    /// the request uses.
    /// 
    ///  
    /// <para>
    /// A setting that you don't override keeps the value that would otherwise apply to the
    /// message. Depending on the setting, that value comes from the configuration set that
    /// the message uses, from your account-level settings, or from the Amazon SES default.
    /// </para>
    /// </summary>
    public partial class ConfigurationOverrides
    {
        private TrackingConfigurationOverrides _tracking;

        /// <summary>
        /// Gets and sets the property Tracking. 
        /// <para>
        /// An object that overrides the open and click tracking settings that would otherwise
        /// apply to the message.
        /// </para>
        /// </summary>
        public TrackingConfigurationOverrides Tracking
        {
            get { return this._tracking; }
            set { this._tracking = value; }
        }

        // Check to see if Tracking property is set
        internal bool IsSetTracking()
        {
            return this._tracking != null;
        }

    }
}