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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Specifies the execution engine (cluster) to run the notebook and perform the notebook
    /// execution, for example, an EMR cluster.
    /// </summary>
    public partial class ExecutionEngineConfig
    {
        private string _id;
        private string _masterInstanceSecurityGroupId;
        private ExecutionEngineType _type;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the execution engine. For an EMR cluster, this is the cluster
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MasterInstanceSecurityGroupId. 
        /// <para>
        /// An optional unique ID of an EC2 security group to associate with the master instance
        /// of the EMR cluster for this notebook execution. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-managed-notebooks-security-groups.html">Specifying
        /// EC2 Security Groups for EMR Notebooks</a> in the <i>EMR Management Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string MasterInstanceSecurityGroupId
        {
            get { return this._masterInstanceSecurityGroupId; }
            set { this._masterInstanceSecurityGroupId = value; }
        }

        // Check to see if MasterInstanceSecurityGroupId property is set
        internal bool IsSetMasterInstanceSecurityGroupId()
        {
            return this._masterInstanceSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of execution engine. A value of <code>EMR</code> specifies an EMR cluster.
        /// </para>
        /// </summary>
        public ExecutionEngineType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}