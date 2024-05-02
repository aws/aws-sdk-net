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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Container for the parameters to the GetExperimentTargetAccountConfiguration operation.
    /// Gets information about the specified target account configuration of the experiment.
    /// </summary>
    public partial class GetExperimentTargetAccountConfigurationRequest : AmazonFISRequest
    {
        private string _accountId;
        private string _experimentId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the target account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=48)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentId. 
        /// <para>
        /// The ID of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ExperimentId
        {
            get { return this._experimentId; }
            set { this._experimentId = value; }
        }

        // Check to see if ExperimentId property is set
        internal bool IsSetExperimentId()
        {
            return this._experimentId != null;
        }

    }
}