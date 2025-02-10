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
    /// The error type.
    /// </summary>
    public partial class NamespaceInfoV2
    {
        private string _arn;
        private string _capacityRegion;
        private NamespaceStatus _creationStatus;
        private string _iamIdentityCenterApplicationArn;
        private string _iamIdentityCenterInstanceArn;
        private IdentityStore _identityStore;
        private string _name;
        private NamespaceError _namespaceError;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The namespace ARN.
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
        /// The namespace Amazon Web Services Region.
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
        /// The creation status of a namespace that is not yet completely created.
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
        /// Gets and sets the property IamIdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center application.
        /// </para>
        /// </summary>
        public string IamIdentityCenterApplicationArn
        {
            get { return this._iamIdentityCenterApplicationArn; }
            set { this._iamIdentityCenterApplicationArn = value; }
        }

        // Check to see if IamIdentityCenterApplicationArn property is set
        internal bool IsSetIamIdentityCenterApplicationArn()
        {
            return this._iamIdentityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamIdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM Identity Center instance.
        /// </para>
        /// </summary>
        public string IamIdentityCenterInstanceArn
        {
            get { return this._iamIdentityCenterInstanceArn; }
            set { this._iamIdentityCenterInstanceArn = value; }
        }

        // Check to see if IamIdentityCenterInstanceArn property is set
        internal bool IsSetIamIdentityCenterInstanceArn()
        {
            return this._iamIdentityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStore. 
        /// <para>
        /// The identity store used for the namespace.
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
        /// The name of the error.
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
        /// Gets and sets the property NamespaceError. 
        /// <para>
        /// An error that occurred when the namespace was created.
        /// </para>
        /// </summary>
        public NamespaceError NamespaceError
        {
            get { return this._namespaceError; }
            set { this._namespaceError = value; }
        }

        // Check to see if NamespaceError property is set
        internal bool IsSetNamespaceError()
        {
            return this._namespaceError != null;
        }

    }
}