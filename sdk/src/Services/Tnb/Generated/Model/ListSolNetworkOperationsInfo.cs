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
    /// Information parameters for a network operation.
    /// </summary>
    public partial class ListSolNetworkOperationsInfo
    {
        private string _arn;
        private ProblemDetails _error;
        private string _id;
        private LcmOperationType _lcmOperationType;
        private ListSolNetworkOperationsMetadata _metadata;
        private string _nsInstanceId;
        private NsLcmOperationState _operationState;

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
        /// Error related to this specific network operation.
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
        /// ID of this network operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Type of lifecycle management network operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Metadata related to this network operation.
        /// </para>
        /// </summary>
        public ListSolNetworkOperationsMetadata Metadata
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
        /// ID of the network instance related to this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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

    }
}