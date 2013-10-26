/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>Conversion Task
    /// </summary>
    public class ConversionTask
    {
        
        private string conversionTaskId;
        private string expirationTime;
        private ImportInstanceTaskDetails importInstance;
        private ImportVolumeTaskDetails importVolume;
        private ConversionTaskState state;
        private string statusMessage;
        private List<Tag> tags = new List<Tag>();

        public string ConversionTaskId
        {
            get { return this.conversionTaskId; }
            set { this.conversionTaskId = value; }
        }

        // Check to see if ConversionTaskId property is set
        internal bool IsSetConversionTaskId()
        {
            return this.conversionTaskId != null;
        }
        public string ExpirationTime
        {
            get { return this.expirationTime; }
            set { this.expirationTime = value; }
        }

        // Check to see if ExpirationTime property is set
        internal bool IsSetExpirationTime()
        {
            return this.expirationTime != null;
        }
        public ImportInstanceTaskDetails ImportInstance
        {
            get { return this.importInstance; }
            set { this.importInstance = value; }
        }

        // Check to see if ImportInstance property is set
        internal bool IsSetImportInstance()
        {
            return this.importInstance != null;
        }
        public ImportVolumeTaskDetails ImportVolume
        {
            get { return this.importVolume; }
            set { this.importVolume = value; }
        }

        // Check to see if ImportVolume property is set
        internal bool IsSetImportVolume()
        {
            return this.importVolume != null;
        }
        public ConversionTaskState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;
        }
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
