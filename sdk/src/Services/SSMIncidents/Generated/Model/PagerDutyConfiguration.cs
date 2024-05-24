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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Details about the PagerDuty configuration for a response plan.
    /// </summary>
    public partial class PagerDutyConfiguration
    {
        private string _name;
        private PagerDutyIncidentConfiguration _pagerDutyIncidentConfiguration;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the PagerDuty configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property PagerDutyIncidentConfiguration. 
        /// <para>
        /// Details about the PagerDuty service associated with the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PagerDutyIncidentConfiguration PagerDutyIncidentConfiguration
        {
            get { return this._pagerDutyIncidentConfiguration; }
            set { this._pagerDutyIncidentConfiguration = value; }
        }

        // Check to see if PagerDutyIncidentConfiguration property is set
        internal bool IsSetPagerDutyIncidentConfiguration()
        {
            return this._pagerDutyIncidentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ID of the Amazon Web Services Secrets Manager secret that stores your PagerDuty
        /// key, either a General Access REST API Key or User Token REST API Key, and other user
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}