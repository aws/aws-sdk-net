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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains the generated policy details.
    /// </summary>
    public partial class GeneratedPolicyProperties
    {
        private CloudTrailProperties _cloudTrailProperties;
        private bool? _isComplete;
        private string _principalArn;

        /// <summary>
        /// Gets and sets the property CloudTrailProperties. 
        /// <para>
        /// Lists details about the <c>Trail</c> used to generated policy.
        /// </para>
        /// </summary>
        public CloudTrailProperties CloudTrailProperties
        {
            get { return this._cloudTrailProperties; }
            set { this._cloudTrailProperties = value; }
        }

        // Check to see if CloudTrailProperties property is set
        internal bool IsSetCloudTrailProperties()
        {
            return this._cloudTrailProperties != null;
        }

        /// <summary>
        /// Gets and sets the property IsComplete. 
        /// <para>
        /// This value is set to <c>true</c> if the generated policy contains all possible actions
        /// for a service that IAM Access Analyzer identified from the CloudTrail trail that you
        /// specified, and <c>false</c> otherwise.
        /// </para>
        /// </summary>
        public bool? IsComplete
        {
            get { return this._isComplete; }
            set { this._isComplete = value; }
        }

        // Check to see if IsComplete property is set
        internal bool IsSetIsComplete()
        {
            return this._isComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the IAM entity (user or role) for which you are generating a policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

    }
}