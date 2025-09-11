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
    /// Container for the parameters to the CreateNamespace operation.
    /// (Enterprise edition only) Creates a new namespace for you to use with Amazon QuickSight.
    /// 
    ///  
    /// <para>
    /// A namespace allows you to isolate the QuickSight users and groups that are registered
    /// for that namespace. Users that access the namespace can share assets only with other
    /// users or groups in the same namespace. They can't see users and groups in other namespaces.
    /// You can create a namespace after your Amazon Web Services account is subscribed to
    /// QuickSight. The namespace must be unique within the Amazon Web Services account. By
    /// default, there is a limit of 100 namespaces per Amazon Web Services account. To increase
    /// your limit, create a ticket with Amazon Web Services Support. 
    /// </para>
    /// </summary>
    public partial class CreateNamespaceRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private IdentityStore _identityStore;
        private string _awsNamespace;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that you want to create the QuickSight
        /// namespace in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityStore. 
        /// <para>
        /// Specifies the type of your user identity directory. Currently, this supports users
        /// with an identity type of <c>QUICKSIGHT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name that you want to use to describe the new namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you want to associate with the namespace that you're creating.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}