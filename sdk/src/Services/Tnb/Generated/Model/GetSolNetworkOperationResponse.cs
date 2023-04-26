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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// This is the response object from the GetSolNetworkOperation operation.
    /// </summary>
    public partial class GetSolNetworkOperationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private ProblemDetails _error;
        private string _id;
        private LcmOperationType _lcmOperationType;
        private GetSolNetworkOperationMetadata _metadata;
        private string _nsInstanceId;
        private NsLcmOperationState _operationState;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<GetSolNetworkOperationTaskDetails> _tasks = new List<GetSolNetworkOperationTaskDetails>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Network operation ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error related to this specific network operation occurrence.
        /// </para>
        /// </summary>
        public ProblemDetails Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of this network operation occurrence.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LcmOperationType. 
        /// <para>
        /// Type of the operation represented by this occurrence.
        /// </para>
        /// </summary>
        public LcmOperationType LcmOperationType
        {
            get { return this._lcmOperationType; }
            set { this._lcmOperationType = value; }
        }

        // Check to see if LcmOperationType property is set
        internal bool IsSetLcmOperationType()
        {
            return this._lcmOperationType != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata of this network operation occurrence.
        /// </para>
        /// </summary>
        public GetSolNetworkOperationMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property NsInstanceId. 
        /// <para>
        /// ID of the network operation instance.
        /// </para>
        /// </summary>
        public string NsInstanceId
        {
            get { return this._nsInstanceId; }
            set { this._nsInstanceId = value; }
        }

        // Check to see if NsInstanceId property is set
        internal bool IsSetNsInstanceId()
        {
            return this._nsInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property OperationState. 
        /// <para>
        /// The state of the network operation.
        /// </para>
        /// </summary>
        public NsLcmOperationState OperationState
        {
            get { return this._operationState; }
            set { this._operationState = value; }
        }

        // Check to see if OperationState property is set
        internal bool IsSetOperationState()
        {
            return this._operationState != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tasks. 
        /// <para>
        /// All tasks associated with this operation occurrence.
        /// </para>
        /// </summary>
        public List<GetSolNetworkOperationTaskDetails> Tasks
        {
            get { return this._tasks; }
            set { this._tasks = value; }
        }

        // Check to see if Tasks property is set
        internal bool IsSetTasks()
        {
            return this._tasks != null && this._tasks.Count > 0; 
        }

    }
}