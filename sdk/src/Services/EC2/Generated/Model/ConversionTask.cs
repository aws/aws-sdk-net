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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a conversion task.
    /// </summary>
    public partial class ConversionTask
    {
        private string _conversionTaskId;
        private string _expirationTime;
        private ImportInstanceTaskDetails _importInstance;
        private ImportVolumeTaskDetails _importVolume;
        private ConversionTaskState _state;
        private string _statusMessage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConversionTaskId. 
        /// <para>
        /// The ID of the conversion task.
        /// </para>
        /// </summary>
        public string ConversionTaskId
        {
            get { return this._conversionTaskId; }
            set { this._conversionTaskId = value; }
        }

        // Check to see if ConversionTaskId property is set
        internal bool IsSetConversionTaskId()
        {
            return this._conversionTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The time when the task expires. If the upload isn't complete before the expiration
        /// time, we automatically cancel the task.
        /// </para>
        /// </summary>
        public string ExpirationTime
        {
            get { return this._expirationTime; }
            set { this._expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this._expirationTime != null;
        }

        /// <summary>
        /// Gets and sets the property ImportInstance. 
        /// <para>
        /// If the task is for importing an instance, this contains information about the import
        /// instance task.
        /// </para>
        /// </summary>
        public ImportInstanceTaskDetails ImportInstance
        {
            get { return this._importInstance; }
            set { this._importInstance = value; }
        }

        // Check to see if ImportInstance property is set
        internal bool IsSetImportInstance()
        {
            return this._importInstance != null;
        }

        /// <summary>
        /// Gets and sets the property ImportVolume. 
        /// <para>
        /// If the task is for importing a volume, this contains information about the import
        /// volume task.
        /// </para>
        /// </summary>
        public ImportVolumeTaskDetails ImportVolume
        {
            get { return this._importVolume; }
            set { this._importVolume = value; }
        }

        // Check to see if ImportVolume property is set
        internal bool IsSetImportVolume()
        {
            return this._importVolume != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the conversion task.
        /// </para>
        /// </summary>
        public ConversionTaskState State
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message related to the conversion task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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