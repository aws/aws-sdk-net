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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by AMI.
    /// </summary>
    public partial class AmiAggregationResponse
    {
        private string _accountId;
        private long? _affectedInstances;
        private string _ami;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property AffectedInstances. 
        /// <para>
        /// The IDs of Amazon EC2 instances using this AMI.
        /// </para>
        /// </summary>
        public long AffectedInstances
        {
            get { return this._affectedInstances.GetValueOrDefault(); }
            set { this._affectedInstances = value; }
        }

        // Check to see if AffectedInstances property is set
        internal bool IsSetAffectedInstances()
        {
            return this._affectedInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// The ID of the AMI that findings were aggregated for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ami
        {
            get { return this._ami; }
            set { this._ami = value; }
        }

        // Check to see if Ami property is set
        internal bool IsSetAmi()
        {
            return this._ami != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}