/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{

    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class ConversionTaskType
    {    
        private string conversionTaskIdField;
        private string expirationTimeField;
        private ImportVolumeTaskDetailsType importVolumeRequestField;
        private ImportInstanceTaskDetailsType importInstanceRequestField;
        private string stateField;
        private string statusMessageField;

        /// <summary>
        /// Gets and sets the ConversionTaskId property.
        /// ID of the conversion task.
        /// </summary>
        [XmlElementAttribute(ElementName = "ConversionTaskId")]
        public string ConversionTaskId
        {
            get { return this.conversionTaskIdField; }
            set { this.conversionTaskIdField = value; }
        }

        /// <summary>
        /// Sets the ConversionTaskId property
        /// </summary>
        /// <param name="conversionTaskId">ID of the conversion task.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithConversionTaskId(string conversionTaskId)
        {
            this.conversionTaskIdField = conversionTaskId;
            return this;
        }

        /// <summary>
        /// Checks if ConversionTaskId property is set
        /// </summary>
        /// <returns>true if ConversionTaskId property is set</returns>
        public bool IsSetConversionTaskId()
        {
            return this.conversionTaskIdField != null;
        }

        /// <summary>
        /// Gets and sets the ExpirationTime property.
        /// When the task expires. If the upload isn't complete before the expiration time, the task is automatically canceled.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExpirationTime")]
        public string ExpirationTime
        {
            get { return this.expirationTimeField; }
            set { this.expirationTimeField = value; }
        }

        /// <summary>
        /// Sets the ExpirationTime property
        /// </summary>
        /// <param name="expirationTime">When the task expires. If the upload isn't complete before the expiration time, the task is automatically canceled.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithExpirationTime(string expirationTime)
        {
            this.expirationTimeField = expirationTime;
            return this;
        }

        /// <summary>
        /// Checks if ExpirationTime property is set
        /// </summary>
        /// <returns>true if ExpirationTime property is set</returns>
        public bool IsSetExpirationTime()
        {
            return this.expirationTimeField != null;
        }

        /// <summary>
        /// Gets and sets the ImportVolumeRequest property.
        /// If the task is for importing a volume, this contains information about the import volume task.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImportVolumeRequest")]
        public ImportVolumeTaskDetailsType ImportVolumeRequest
        {
            get { return this.importVolumeRequestField; }
            set { this.importVolumeRequestField = value; }
        }

        /// <summary>
        /// Sets the ImportVolumeRequest property
        /// </summary>
        /// <param name="importVolumeRequest">If the task is for importing a volume, this contains information about the import volume task.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithImportVolumeRequest(ImportVolumeTaskDetailsType importVolumeRequest)
        {
            this.importVolumeRequestField = importVolumeRequest;
            return this;
        }

        /// <summary>
        /// Checks if ImportVolumeRequest property is set
        /// </summary>
        /// <returns>true if ImportVolumeRequest property is set</returns>
        public bool IsSetImportVolumeRequest()
        {
            return this.importVolumeRequestField != null;
        }

        /// <summary>
        /// Gets and sets the ImportInstanceRequest property.
        /// If the task is for importing an instance, this contains information about the import instance task.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImportInstanceRequest")]
        public ImportInstanceTaskDetailsType ImportInstanceRequest
        {
            get { return this.importInstanceRequestField; }
            set { this.importInstanceRequestField = value; }
        }

        /// <summary>
        /// Sets the ImportInstanceRequest property
        /// </summary>
        /// <param name="importInstanceRequest">If the task is for importing an instance, this contains information about the import instance task.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithImportInstanceRequest(ImportInstanceTaskDetailsType importInstanceRequest)
        {
            this.importInstanceRequestField = importInstanceRequest;
            return this;
        }

        /// <summary>
        /// Checks if ImportInstanceRequest property is set
        /// </summary>
        /// <returns>true if ImportInstanceRequest property is set</returns>
        public bool IsSetImportInstanceRequest()
        {
            return this.importInstanceRequestField != null;
        }

        /// <summary>
        /// Gets and sets the State property.
        /// State of the conversion task.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">State of the conversion task.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

        /// <summary>
        /// Gets and sets the StatusMessage property.
        /// Status message related to the conversion task.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField; }
            set { this.statusMessageField = value; }
        }

        /// <summary>
        /// Sets the StatusMessage property
        /// </summary>
        /// <param name="statusMessage">Status message related to the conversion task.</param>
        /// <returns>this instance</returns>
        public ConversionTaskType WithStatusMessage(string statusMessage)
        {
            this.statusMessageField = statusMessage;
            return this;
        }

        /// <summary>
        /// Checks if StatusMessage property is set
        /// </summary>
        /// <returns>true if StatusMessage property is set</returns>
        public bool IsSetStatusMessage()
        {
            return this.statusMessageField != null;
        }

    }
}
