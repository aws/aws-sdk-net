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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents input information for uploading a file to a benefit application.
    /// </summary>
    public partial class FileInput
    {
        private string _businessUseCase;
        private string _fileURI;

        /// <summary>
        /// Gets and sets the property BusinessUseCase. 
        /// <para>
        /// The business purpose or use case that this file supports in the benefit application.
        /// </para>
        /// </summary>
        public string BusinessUseCase
        {
            get { return this._businessUseCase; }
            set { this._businessUseCase = value; }
        }

        // Check to see if BusinessUseCase property is set
        internal bool IsSetBusinessUseCase()
        {
            return this._businessUseCase != null;
        }

        /// <summary>
        /// Gets and sets the property FileURI. 
        /// <para>
        /// The URI or location where the file should be stored or has been uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string FileURI
        {
            get { return this._fileURI; }
            set { this._fileURI = value; }
        }

        // Check to see if FileURI property is set
        internal bool IsSetFileURI()
        {
            return this._fileURI != null;
        }

    }
}