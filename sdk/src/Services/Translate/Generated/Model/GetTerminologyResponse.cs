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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the GetTerminology operation.
    /// </summary>
    public partial class GetTerminologyResponse : AmazonWebServiceResponse
    {
        private TerminologyDataLocation _terminologyDataLocation;
        private TerminologyProperties _terminologyProperties;

        /// <summary>
        /// Gets and sets the property TerminologyDataLocation. 
        /// <para>
        /// The data location of the custom terminology being retrieved. The custom terminology
        /// file is returned in a presigned url that has a 30 minute expiration.
        /// </para>
        /// </summary>
        public TerminologyDataLocation TerminologyDataLocation
        {
            get { return this._terminologyDataLocation; }
            set { this._terminologyDataLocation = value; }
        }

        // Check to see if TerminologyDataLocation property is set
        internal bool IsSetTerminologyDataLocation()
        {
            return this._terminologyDataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TerminologyProperties. 
        /// <para>
        /// The properties of the custom terminology being retrieved.
        /// </para>
        /// </summary>
        public TerminologyProperties TerminologyProperties
        {
            get { return this._terminologyProperties; }
            set { this._terminologyProperties = value; }
        }

        // Check to see if TerminologyProperties property is set
        internal bool IsSetTerminologyProperties()
        {
            return this._terminologyProperties != null;
        }

    }
}