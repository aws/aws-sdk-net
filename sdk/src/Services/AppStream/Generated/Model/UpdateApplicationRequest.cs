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
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the specified application.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonAppStreamRequest
    {
        private string _appBlockArn;
        private List<string> _attributesToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _displayName;
        private S3Location _iconS3Location;
        private string _launchParameters;
        private string _launchPath;
        private string _name;
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property AppBlockArn. 
        /// <para>
        /// The ARN of the app block.
        /// </para>
        /// </summary>
        public string AppBlockArn
        {
            get { return this._appBlockArn; }
            set { this._appBlockArn = value; }
        }

        // Check to see if AppBlockArn property is set
        internal bool IsSetAppBlockArn()
        {
            return this._appBlockArn != null;
        }

        /// <summary>
        /// Gets and sets the property AttributesToDelete. 
        /// <para>
        /// The attributes to delete for an application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> AttributesToDelete
        {
            get { return this._attributesToDelete; }
            set { this._attributesToDelete = value; }
        }

        // Check to see if AttributesToDelete property is set
        internal bool IsSetAttributesToDelete()
        {
            return this._attributesToDelete != null && (this._attributesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
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
        /// The display name of the application. This name is visible to users in the application
        /// catalog.
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
        /// Gets and sets the property IconS3Location. 
        /// <para>
        /// The icon S3 location of the application.
        /// </para>
        /// </summary>
        public S3Location IconS3Location
        {
            get { return this._iconS3Location; }
            set { this._iconS3Location = value; }
        }

        // Check to see if IconS3Location property is set
        internal bool IsSetIconS3Location()
        {
            return this._iconS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchParameters. 
        /// <para>
        /// The launch parameters of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string LaunchParameters
        {
            get { return this._launchParameters; }
            set { this._launchParameters = value; }
        }

        // Check to see if LaunchParameters property is set
        internal bool IsSetLaunchParameters()
        {
            return this._launchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPath. 
        /// <para>
        /// The launch path of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string LaunchPath
        {
            get { return this._launchPath; }
            set { this._launchPath = value; }
        }

        // Check to see if LaunchPath property is set
        internal bool IsSetLaunchPath()
        {
            return this._launchPath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application. This name is visible to users when display name is not
        /// specified.
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
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The working directory of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}