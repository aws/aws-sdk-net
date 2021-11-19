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
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private string _name;
        private ScriptDetails _setupScriptDetails;
        private S3Location _sourceS3Location;

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
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// Gets and sets the property SetupScriptDetails. 
        /// <para>
        /// The setup script details of the app block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}