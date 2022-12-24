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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DecryptStepDetails
    {
        private InputFileLocation _destinationFileLocation;
        private string _name;
        private OverwriteExisting _overwriteExisting;
        private string _sourceFileLocation;
        private EncryptionType _type;

        /// <summary>
        /// Gets and sets the property DestinationFileLocation.
        /// </summary>
        [AWSProperty(Required=true)]
        public InputFileLocation DestinationFileLocation
        {
            get { return this._destinationFileLocation; }
            set { this._destinationFileLocation = value; }
        }

        // Check to see if DestinationFileLocation property is set
        internal bool IsSetDestinationFileLocation()
        {
            return this._destinationFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Max=30)]
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
        /// Gets and sets the property OverwriteExisting.
        /// </summary>
        public OverwriteExisting OverwriteExisting
        {
            get { return this._overwriteExisting; }
            set { this._overwriteExisting = value; }
        }

        // Check to see if OverwriteExisting property is set
        internal bool IsSetOverwriteExisting()
        {
            return this._overwriteExisting != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileLocation.
        /// </summary>
        [AWSProperty(Max=256)]
        public string SourceFileLocation
        {
            get { return this._sourceFileLocation; }
            set { this._sourceFileLocation = value; }
        }

        // Check to see if SourceFileLocation property is set
        internal bool IsSetSourceFileLocation()
        {
            return this._sourceFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}