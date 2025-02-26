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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the CreateKeySigningKey operation.
    /// </summary>
    public partial class CreateKeySigningKeyResponse : AmazonWebServiceResponse
    {
        private ChangeInfo _changeInfo;
        private KeySigningKey _keySigningKey;
        private string _location;

        /// <summary>
        /// Gets and sets the property ChangeInfo.
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeInfo ChangeInfo
        {
            get { return this._changeInfo; }
            set { this._changeInfo = value; }
        }

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this._changeInfo != null;
        }

        /// <summary>
        /// Gets and sets the property KeySigningKey. 
        /// <para>
        /// The key-signing key (KSK) that the request creates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeySigningKey KeySigningKey
        {
            get { return this._keySigningKey; }
            set { this._keySigningKey = value; }
        }

        // Check to see if KeySigningKey property is set
        internal bool IsSetKeySigningKey()
        {
            return this._keySigningKey != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new key-signing key (KSK).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}