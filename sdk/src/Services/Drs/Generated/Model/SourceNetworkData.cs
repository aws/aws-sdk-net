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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of Source Network related to a job event.
    /// </summary>
    public partial class SourceNetworkData
    {
        private string _sourceNetworkID;
        private string _sourceVpc;
        private string _stackName;
        private string _targetVpc;

        /// <summary>
        /// Gets and sets the property SourceNetworkID. 
        /// <para>
        /// Source Network ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string SourceNetworkID
        {
            get { return this._sourceNetworkID; }
            set { this._sourceNetworkID = value; }
        }

        // Check to see if SourceNetworkID property is set
        internal bool IsSetSourceNetworkID()
        {
            return this._sourceNetworkID != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVpc. 
        /// <para>
        /// VPC ID protected by the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string SourceVpc
        {
            get { return this._sourceVpc; }
            set { this._sourceVpc = value; }
        }

        // Check to see if SourceVpc property is set
        internal bool IsSetSourceVpc()
        {
            return this._sourceVpc != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// CloudFormation stack name that was deployed for recovering the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVpc. 
        /// <para>
        /// ID of the recovered VPC following Source Network recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=21)]
        public string TargetVpc
        {
            get { return this._targetVpc; }
            set { this._targetVpc = value; }
        }

        // Check to see if TargetVpc property is set
        internal bool IsSetTargetVpc()
        {
            return this._targetVpc != null;
        }

    }
}