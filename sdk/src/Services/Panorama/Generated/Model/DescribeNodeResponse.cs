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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// This is the response object from the DescribeNode operation.
    /// </summary>
    public partial class DescribeNodeResponse : AmazonWebServiceResponse
    {
        private string _assetName;
        private NodeCategory _category;
        private DateTime? _createdTime;
        private string _description;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _nodeId;
        private NodeInterface _nodeInterface;
        private string _ownerAccount;
        private string _packageArn;
        private string _packageId;
        private string _packageName;
        private string _packageVersion;
        private string _patchVersion;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The node's asset name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The node's category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the node was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The node's description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// When the node was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The node's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The node's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeInterface. 
        /// <para>
        /// The node's interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeInterface NodeInterface
        {
            get { return this._nodeInterface; }
            set { this._nodeInterface = value; }
        }

        // Check to see if NodeInterface property is set
        internal bool IsSetNodeInterface()
        {
            return this._nodeInterface != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The account ID of the node's owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PackageArn. 
        /// <para>
        /// The node's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageArn
        {
            get { return this._packageArn; }
            set { this._packageArn = value; }
        }

        // Check to see if PackageArn property is set
        internal bool IsSetPackageArn()
        {
            return this._packageArn != null;
        }

        /// <summary>
        /// Gets and sets the property PackageId. 
        /// <para>
        /// The node's package ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PackageId
        {
            get { return this._packageId; }
            set { this._packageId = value; }
        }

        // Check to see if PackageId property is set
        internal bool IsSetPackageId()
        {
            return this._packageId != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The node's package name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The node's package version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PatchVersion. 
        /// <para>
        /// The node's patch version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string PatchVersion
        {
            get { return this._patchVersion; }
            set { this._patchVersion = value; }
        }

        // Check to see if PatchVersion property is set
        internal bool IsSetPatchVersion()
        {
            return this._patchVersion != null;
        }

    }
}