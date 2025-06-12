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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The defining characteristics of a specific version of an Amazon Web Services TOE component.
    /// </summary>
    public partial class ComponentVersion
    {
        private string _arn;
        private string _dateCreated;
        private string _description;
        private string _name;
        private string _owner;
        private Platform _platform;
        private List<ProductCodeListItem> _productCodes = AWSConfigs.InitializeCollections ? new List<ProductCodeListItem>() : null;
        private ComponentStatus _status;
        private List<string> _supportedOsVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ComponentType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
        /// </para>
        ///  <note> 
        /// <para>
        /// Semantic versioning is included in each object's Amazon Resource Name (ARN), at the
        /// level that applies to that object as follows:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Versionless ARNs and Name ARNs do not include specific values in any of the nodes.
        /// The nodes are either left off entirely, or they are specified as wildcards, for example:
        /// x.x.x.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version ARNs have only the first three nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Build version ARNs have all four nodes, and point to a specific build for a specific
        /// version of an object.
        /// </para>
        ///  </li> </ol> </note>
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date that the component was created.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the component.
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// Contains product codes that are used for billing purposes for Amazon Web Services
        /// Marketplace components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCodeListItem> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && (this._productCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the current status of the component version.
        /// </para>
        /// </summary>
        public ComponentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedOsVersions. 
        /// <para>
        /// he operating system (OS) version supported by the component. If the OS information
        /// is available, a prefix match is performed against the base image OS version during
        /// image recipe creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> SupportedOsVersions
        {
            get { return this._supportedOsVersions; }
            set { this._supportedOsVersions = value; }
        }

        // Check to see if SupportedOsVersions property is set
        internal bool IsSetSupportedOsVersions()
        {
            return this._supportedOsVersions != null && (this._supportedOsVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the component denotes whether the component is used to build the image
        /// or only to test it.
        /// </para>
        /// </summary>
        public ComponentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The semantic version of the component.
        /// </para>
        ///  <note> 
        /// <para>
        /// The semantic version has four nodes: &lt;major&gt;.&lt;minor&gt;.&lt;patch&gt;/&lt;build&gt;.
        /// You can assign values for the first three, and can filter on all of them.
        /// </para>
        ///  
        /// <para>
        ///  <b>Assignment:</b> For the first three nodes you can assign any positive integer
        /// value, including zero, with an upper limit of 2^30-1, or 1073741823 for each node.
        /// Image Builder automatically assigns the build number to the fourth node.
        /// </para>
        ///  
        /// <para>
        ///  <b>Patterns:</b> You can use any numeric pattern that adheres to the assignment requirements
        /// for the nodes that you can assign. For example, you might choose a software version
        /// pattern, such as 1.0.0, or a date, such as 2021.01.01.
        /// </para>
        ///  
        /// <para>
        ///  <b>Filtering:</b> With semantic versioning, you have the flexibility to use wildcards
        /// (x) to specify the most recent versions or nodes when selecting the base image or
        /// components for your recipe. When you use a wildcard in any node, all nodes to the
        /// right of the first wildcard must also be wildcards.
        /// </para>
        ///  </note>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}