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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The details of a blueprint.
    /// </summary>
    public partial class Blueprint
    {
        private string _blueprintLocation;
        private string _blueprintServiceLocation;
        private DateTime? _createdOn;
        private string _description;
        private string _errorMessage;
        private LastActiveDefinition _lastActiveDefinition;
        private DateTime? _lastModifiedOn;
        private string _name;
        private string _parameterSpec;
        private BlueprintStatus _status;

        /// <summary>
        /// Gets and sets the property BlueprintLocation. 
        /// <para>
        /// Specifies the path in Amazon S3 where the blueprint is published.
        /// </para>
        /// </summary>
        public string BlueprintLocation
        {
            get { return this._blueprintLocation; }
            set { this._blueprintLocation = value; }
        }

        // Check to see if BlueprintLocation property is set
        internal bool IsSetBlueprintLocation()
        {
            return this._blueprintLocation != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintServiceLocation. 
        /// <para>
        /// Specifies a path in Amazon S3 where the blueprint is copied when you call <c>CreateBlueprint/UpdateBlueprint</c>
        /// to register the blueprint in Glue.
        /// </para>
        /// </summary>
        public string BlueprintServiceLocation
        {
            get { return this._blueprintServiceLocation; }
            set { this._blueprintServiceLocation = value; }
        }

        // Check to see if BlueprintServiceLocation property is set
        internal bool IsSetBlueprintServiceLocation()
        {
            return this._blueprintServiceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The date and time the blueprint was registered.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn
        {
            get { return this._createdOn; }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastActiveDefinition. 
        /// <para>
        /// When there are multiple versions of a blueprint and the latest version has some errors,
        /// this attribute indicates the last successful blueprint definition that is available
        /// with the service.
        /// </para>
        /// </summary>
        public LastActiveDefinition LastActiveDefinition
        {
            get { return this._lastActiveDefinition; }
            set { this._lastActiveDefinition = value; }
        }

        // Check to see if LastActiveDefinition property is set
        internal bool IsSetLastActiveDefinition()
        {
            return this._lastActiveDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The date and time the blueprint was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn
        {
            get { return this._lastModifiedOn; }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property ParameterSpec. 
        /// <para>
        /// A JSON string that indicates the list of parameter specifications for the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string ParameterSpec
        {
            get { return this._parameterSpec; }
            set { this._parameterSpec = value; }
        }

        // Check to see if ParameterSpec property is set
        internal bool IsSetParameterSpec()
        {
            return this._parameterSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the blueprint registration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating — The blueprint registration is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Active — The blueprint has been successfully registered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updating — An update to the blueprint registration is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed — The blueprint registration failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BlueprintStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}