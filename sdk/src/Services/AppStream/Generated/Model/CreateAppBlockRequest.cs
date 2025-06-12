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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppBlock operation.
    /// Creates an app block.
    /// 
    ///  
    /// <para>
    /// App blocks are an Amazon AppStream 2.0 resource that stores the details about the
    /// virtual hard disk in an S3 bucket. It also stores the setup script with details about
    /// how to mount the virtual hard disk. The virtual hard disk includes the application
    /// binaries and other files necessary to launch your applications. Multiple applications
    /// can be assigned to a single app block.
    /// </para>
    ///  
    /// <para>
    /// This is only supported for Elastic fleets.
    /// </para>
    /// </summary>
    public partial class CreateAppBlockRequest : AmazonAppStreamRequest
    {
        private string _description;
        private string _displayName;
        private string _name;
        private PackagingType _packagingType;
        private ScriptDetails _postSetupScriptDetails;
        private ScriptDetails _setupScriptDetails;
        private S3Location _sourceS3Location;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the app block. This is not displayed to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PackagingType. 
        /// <para>
        /// The packaging type of the app block.
        /// </para>
        /// </summary>
        public PackagingType PackagingType
        {
            get { return this._packagingType; }
            set { this._packagingType = value; }
        }

        // Check to see if PackagingType property is set
        internal bool IsSetPackagingType()
        {
            return this._packagingType != null;
        }

        /// <summary>
        /// Gets and sets the property PostSetupScriptDetails. 
        /// <para>
        /// The post setup script details of the app block. This can only be provided for the
        /// <c>APPSTREAM2</c> PackagingType.
        /// </para>
        /// </summary>
        public ScriptDetails PostSetupScriptDetails
        {
            get { return this._postSetupScriptDetails; }
            set { this._postSetupScriptDetails = value; }
        }

        // Check to see if PostSetupScriptDetails property is set
        internal bool IsSetPostSetupScriptDetails()
        {
            return this._postSetupScriptDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SetupScriptDetails. 
        /// <para>
        /// The setup script details of the app block. This must be provided for the <c>CUSTOM</c>
        /// PackagingType.
        /// </para>
        /// </summary>
        public ScriptDetails SetupScriptDetails
        {
            get { return this._setupScriptDetails; }
            set { this._setupScriptDetails = value; }
        }

        // Check to see if SetupScriptDetails property is set
        internal bool IsSetSetupScriptDetails()
        {
            return this._setupScriptDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Location. 
        /// <para>
        /// The source S3 location of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location SourceS3Location
        {
            get { return this._sourceS3Location; }
            set { this._sourceS3Location = value; }
        }

        // Check to see if SourceS3Location property is set
        internal bool IsSetSourceS3Location()
        {
            return this._sourceS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the app block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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