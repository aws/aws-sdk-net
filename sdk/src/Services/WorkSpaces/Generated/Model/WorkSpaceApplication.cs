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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the WorkSpace application.
    /// </summary>
    public partial class WorkSpaceApplication
    {
        private string _applicationId;
        private DateTime? _created;
        private string _description;
        private WorkSpaceApplicationLicenseType _licenseType;
        private string _name;
        private string _owner;
        private WorkSpaceApplicationState _state;
        private List<string> _supportedComputeTypeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedOperatingSystemNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time the application is created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the WorkSpace application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license availability for the applications.
        /// </para>
        /// </summary>
        public WorkSpaceApplicationLicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the WorkSpace application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The owner of the WorkSpace application.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The status of WorkSpace application.
        /// </para>
        /// </summary>
        public WorkSpaceApplicationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedComputeTypeNames. 
        /// <para>
        /// The supported compute types of the WorkSpace application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedComputeTypeNames
        {
            get { return this._supportedComputeTypeNames; }
            set { this._supportedComputeTypeNames = value; }
        }

        // Check to see if SupportedComputeTypeNames property is set
        internal bool IsSetSupportedComputeTypeNames()
        {
            return this._supportedComputeTypeNames != null && (this._supportedComputeTypeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedOperatingSystemNames. 
        /// <para>
        /// The supported operating systems of the WorkSpace application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedOperatingSystemNames
        {
            get { return this._supportedOperatingSystemNames; }
            set { this._supportedOperatingSystemNames = value; }
        }

        // Check to see if SupportedOperatingSystemNames property is set
        internal bool IsSetSupportedOperatingSystemNames()
        {
            return this._supportedOperatingSystemNames != null && (this._supportedOperatingSystemNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}