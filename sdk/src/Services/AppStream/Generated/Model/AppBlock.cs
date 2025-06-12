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
    /// Describes an app block.
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
    public partial class AppBlock
    {
        private List<ErrorDetails> _appBlockErrors = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private string _name;
        private PackagingType _packagingType;
        private ScriptDetails _postSetupScriptDetails;
        private ScriptDetails _setupScriptDetails;
        private S3Location _sourceS3Location;
        private AppBlockState _state;

        /// <summary>
        /// Gets and sets the property AppBlockErrors. 
        /// <para>
        /// The errors of the app block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetails> AppBlockErrors
        {
            get { return this._appBlockErrors; }
            set { this._appBlockErrors = value; }
        }

        // Check to see if AppBlockErrors property is set
        internal bool IsSetAppBlockErrors()
        {
            return this._appBlockErrors != null && (this._appBlockErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the app block.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The created time of the app block.
        /// </para>
        /// </summary>
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
        /// The description of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The display name of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        [AWSProperty(Required=true, Min=1)]
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
        /// The post setup script details of the app block.
        /// </para>
        ///  
        /// <para>
        /// This only applies to app blocks with PackagingType <c>APPSTREAM2</c>.
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
        /// The setup script details of the app block.
        /// </para>
        ///  
        /// <para>
        /// This only applies to app blocks with PackagingType <c>CUSTOM</c>.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the app block.
        /// </para>
        ///  
        /// <para>
        /// An app block with AppStream 2.0 packaging will be in the <c>INACTIVE</c> state if
        /// no application package (VHD) is assigned to it. After an application package (VHD)
        /// is created by an app block builder for an app block, it becomes <c>ACTIVE</c>. 
        /// </para>
        ///  
        /// <para>
        /// Custom app blocks are always in the <c>ACTIVE</c> state and no action is required
        /// to use them.
        /// </para>
        /// </summary>
        public AppBlockState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}