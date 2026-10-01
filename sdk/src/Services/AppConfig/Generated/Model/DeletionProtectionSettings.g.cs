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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// A parameter to configure deletion protection. Deletion protection prevents a user
    /// from deleting a configuration profile or an environment if AppConfig has called either
    /// <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
    /// or for the configuration profile or from the environment during the specified interval.
    /// 
    ///  
    /// <para>
    /// The default interval specified by <c>ProtectionPeriodInMinutes</c> is 60. <c>DeletionProtectionCheck</c>
    /// skips configuration profiles and environments that were created in the past hour.
    /// </para>
    /// </summary>
    public partial class DeletionProtectionSettings
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A parameter that indicates if deletion protection is enabled or not.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property ProtectionPeriodInMinutes. 
        /// <para>
        /// The time interval during which AppConfig monitors for calls to <a href="https://docs.aws.amazon.com/appconfig/2019-10-09/APIReference/API_appconfigdata_GetLatestConfiguration.html">GetLatestConfiguration</a>
        /// or for a configuration profile or from an environment. AppConfig returns an error
        /// if a user calls or for the designated configuration profile or environment. To bypass
        /// the error and delete a configuration profile or an environment, specify <c>BYPASS</c>
        /// for the <c>DeletionProtectionCheck</c> parameter for either or .
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 1440)]
        public int? ProtectionPeriodInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ProtectionPeriodInMinutes property is set.
        /// </summary>
        internal bool IsSetProtectionPeriodInMinutes() => this.ProtectionPeriodInMinutes.HasValue;
    }
}
