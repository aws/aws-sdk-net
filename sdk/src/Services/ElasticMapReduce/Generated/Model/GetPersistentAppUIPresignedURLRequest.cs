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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the GetPersistentAppUIPresignedURL operation.
    /// The presigned URL properties for the cluster's application user interface.
    /// </summary>
    public partial class GetPersistentAppUIPresignedURLRequest : AmazonElasticMapReduceRequest
    {
        private string _applicationId;
        private bool? _authProxyCall;
        private string _executionRoleArn;
        private string _persistentAppUIId;
        private PersistentAppUIType _persistentAppUIType;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID associated with the presigned URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthProxyCall. 
        /// <para>
        /// A boolean that represents if the caller is an authentication proxy call.
        /// </para>
        /// </summary>
        public bool? AuthProxyCall
        {
            get { return this._authProxyCall; }
            set { this._authProxyCall = value; }
        }

        // Check to see if AuthProxyCall property is set
        internal bool IsSetAuthProxyCall()
        {
            return this._authProxyCall.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN associated with the presigned URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUIId. 
        /// <para>
        /// The persistent application user interface ID associated with the presigned URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string PersistentAppUIId
        {
            get { return this._persistentAppUIId; }
            set { this._persistentAppUIId = value; }
        }

        // Check to see if PersistentAppUIId property is set
        internal bool IsSetPersistentAppUIId()
        {
            return this._persistentAppUIId != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentAppUIType. 
        /// <para>
        /// The persistent application user interface type associated with the presigned URL.
        /// </para>
        /// </summary>
        public PersistentAppUIType PersistentAppUIType
        {
            get { return this._persistentAppUIType; }
            set { this._persistentAppUIType = value; }
        }

        // Check to see if PersistentAppUIType property is set
        internal bool IsSetPersistentAppUIType()
        {
            return this._persistentAppUIType != null;
        }

    }
}