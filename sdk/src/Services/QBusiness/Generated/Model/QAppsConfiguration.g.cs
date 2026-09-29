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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information about Amazon Q Apps.
    /// </summary>
    public partial class QAppsConfiguration
    {
        /// <summary>
        /// Gets and sets the property QAppsControlMode. 
        /// <para>
        /// Status information about whether end users can create and use Amazon Q Apps in the
        /// web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QAppsControlMode QAppsControlMode { get; set; }

        /// <summary>
        /// Checks to see if the QAppsControlMode property is set.
        /// </summary>
        internal bool IsSetQAppsControlMode() => this.QAppsControlMode != null;
    }
}
