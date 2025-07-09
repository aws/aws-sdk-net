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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
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
namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Describes a software set.
    /// </summary>
    public partial class SoftwareSet
    {
        private string _arn;
        private string _id;
        private DateTime? _releasedAt;
        private List<Software> _software = AWSConfigs.InitializeCollections ? new List<Software>() : null;
        private DateTime? _supportedUntil;
        private SoftwareSetValidationStatus _validationStatus;
        private string _version;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the software set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the software set.
        /// </para>
        /// </summary>
        public string Id
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
        /// Gets and sets the property ReleasedAt. 
        /// <para>
        /// The timestamp of when the software set was released.
        /// </para>
        /// </summary>
        public DateTime? ReleasedAt
        {
            get { return this._releasedAt; }
            set { this._releasedAt = value; }
        }

        // Check to see if ReleasedAt property is set
        internal bool IsSetReleasedAt()
        {
            return this._releasedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Software. 
        /// <para>
        /// A list of the software components in the software set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Software> Software
        {
            get { return this._software; }
            set { this._software = value; }
        }

        // Check to see if Software property is set
        internal bool IsSetSoftware()
        {
            return this._software != null && (this._software.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedUntil. 
        /// <para>
        /// The timestamp of the end of support for the software set.
        /// </para>
        /// </summary>
        public DateTime? SupportedUntil
        {
            get { return this._supportedUntil; }
            set { this._supportedUntil = value; }
        }

        // Check to see if SupportedUntil property is set
        internal bool IsSetSupportedUntil()
        {
            return this._supportedUntil.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// An option to define if the software set has been validated.
        /// </para>
        /// </summary>
        public SoftwareSetValidationStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the software set.
        /// </para>
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