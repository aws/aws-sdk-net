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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the CreateNamespace operation.
    /// </summary>
    public partial class CreateNamespaceResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _capacityRegion;
        private NamespaceStatus _creationStatus;
        private IdentityStore _identityStore;
        private string _name;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the QuickSight namespace you created. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CapacityRegion. 
        /// <para>
        /// The Amazon Web Services Region; that you want to use for the free SPICE capacity for
        /// the new namespace. This is set to the region that you run CreateNamespace in. 
        /// </para>
        /// </summary>
        public string CapacityRegion
        {
            get { return this._capacityRegion; }
            set { this._capacityRegion = value; }
        }

        // Check to see if CapacityRegion property is set
        internal bool IsSetCapacityRegion()
        {
            return this._capacityRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CreationStatus. 
        /// <para>
        /// The status of the creation of the namespace. This is an asynchronous process. A status
        /// of <c>CREATED</c> means that your namespace is ready to use. If an error occurs, it
        /// indicates if the process is <c>retryable</c> or <c>non-retryable</c>. In the case
        /// of a non-retryable error, refer to the error message for follow-up tasks.
        /// </para>
        /// </summary>
        public NamespaceStatus CreationStatus
        {
            get { return this._creationStatus; }
            set { this._creationStatus = value; }
        }

        // Check to see if CreationStatus property is set
        internal bool IsSetCreationStatus()
        {
            return this._creationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStore. 
        /// <para>
        /// Specifies the type of your user identity directory. Currently, this supports users
        /// with an identity type of <c>QUICKSIGHT</c>.
        /// </para>
        /// </summary>
        public IdentityStore IdentityStore
        {
            get { return this._identityStore; }
            set { this._identityStore = value; }
        }

        // Check to see if IdentityStore property is set
        internal bool IsSetIdentityStore()
        {
            return this._identityStore != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new namespace that you created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}