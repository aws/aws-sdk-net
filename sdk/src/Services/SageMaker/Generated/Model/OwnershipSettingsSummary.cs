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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies summary information about the ownership settings.
    /// </summary>
    public partial class OwnershipSettingsSummary
    {
        private string _ownerUserProfileName;

        /// <summary>
        /// Gets and sets the property OwnerUserProfileName. 
        /// <para>
        /// The user profile who is the owner of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string OwnerUserProfileName
        {
            get { return this._ownerUserProfileName; }
            set { this._ownerUserProfileName = value; }
        }

        // Check to see if OwnerUserProfileName property is set
        internal bool IsSetOwnerUserProfileName()
        {
            return this._ownerUserProfileName != null;
        }

    }
}