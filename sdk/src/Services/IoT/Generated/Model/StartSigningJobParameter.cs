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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information required to start a signing job.
    /// </summary>
    public partial class StartSigningJobParameter
    {
        private Destination _destination;
        private string _signingProfileName;
        private SigningProfileParameter _signingProfileParameter;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location to write the code-signed file.
        /// </para>
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProfileName. 
        /// <para>
        /// The code-signing profile name.
        /// </para>
        /// </summary>
        public string SigningProfileName
        {
            get { return this._signingProfileName; }
            set { this._signingProfileName = value; }
        }

        // Check to see if SigningProfileName property is set
        internal bool IsSetSigningProfileName()
        {
            return this._signingProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProfileParameter. 
        /// <para>
        /// Describes the code-signing profile.
        /// </para>
        /// </summary>
        public SigningProfileParameter SigningProfileParameter
        {
            get { return this._signingProfileParameter; }
            set { this._signingProfileParameter = value; }
        }

        // Check to see if SigningProfileParameter property is set
        internal bool IsSetSigningProfileParameter()
        {
            return this._signingProfileParameter != null;
        }

    }
}