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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The parameters for the action type definition that are provided when the action type
    /// is created or updated.
    /// </summary>
    public partial class ActionTypeDeclaration
    {
        private string _description;
        private ActionTypeExecutor _executor;
        private ActionTypeIdentifier _id;
        private ActionTypeArtifactDetails _inputArtifactDetails;
        private ActionTypeArtifactDetails _outputArtifactDetails;
        private ActionTypePermissions _permissions;
        private List<ActionTypeProperty> _properties = AWSConfigs.InitializeCollections ? new List<ActionTypeProperty>() : null;
        private ActionTypeUrls _urls;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the action type to be updated.
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
        /// Gets and sets the property Executor. 
        /// <para>
        /// Information about the executor for an action type that was created with any supported
        /// integration model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeExecutor Executor
        {
            get { return this._executor; }
            set { this._executor = value; }
        }

        // Check to see if Executor property is set
        internal bool IsSetExecutor()
        {
            return this._executor != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The action category, owner, provider, and version of the action type to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeIdentifier Id
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
        /// Gets and sets the property InputArtifactDetails. 
        /// <para>
        /// Details for the artifacts, such as application files, to be worked on by the action.
        /// For example, the minimum and maximum number of input artifacts allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeArtifactDetails InputArtifactDetails
        {
            get { return this._inputArtifactDetails; }
            set { this._inputArtifactDetails = value; }
        }

        // Check to see if InputArtifactDetails property is set
        internal bool IsSetInputArtifactDetails()
        {
            return this._inputArtifactDetails != null;
        }

        /// <summary>
        /// Gets and sets the property OutputArtifactDetails. 
        /// <para>
        /// Details for the output artifacts, such as a built application, that are the result
        /// of the action. For example, the minimum and maximum number of output artifacts allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeArtifactDetails OutputArtifactDetails
        {
            get { return this._outputArtifactDetails; }
            set { this._outputArtifactDetails = value; }
        }

        // Check to see if OutputArtifactDetails property is set
        internal bool IsSetOutputArtifactDetails()
        {
            return this._outputArtifactDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Details identifying the accounts with permissions to use the action type.
        /// </para>
        /// </summary>
        public ActionTypePermissions Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the action type to be updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<ActionTypeProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Urls. 
        /// <para>
        /// The links associated with the action type to be updated.
        /// </para>
        /// </summary>
        public ActionTypeUrls Urls
        {
            get { return this._urls; }
            set { this._urls = value; }
        }

        // Check to see if Urls property is set
        internal bool IsSetUrls()
        {
            return this._urls != null;
        }

    }
}