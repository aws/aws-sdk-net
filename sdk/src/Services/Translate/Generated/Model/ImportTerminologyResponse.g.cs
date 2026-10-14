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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the ImportTerminology operation.
    /// </summary>
    public partial class ImportTerminologyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuxiliaryDataLocation. 
        /// <para>
        /// The Amazon S3 location of a file that provides any errors or warnings that were produced
        /// by your input file. This file was created when Amazon Translate attempted to create
        /// a terminology resource. The location is returned as a presigned URL to that has a
        /// 30 minute expiration.
        /// </para>
        /// </summary>
        public TerminologyDataLocation AuxiliaryDataLocation { get; set; }

        /// <summary>
        /// Checks to see if the AuxiliaryDataLocation property is set.
        /// </summary>
        internal bool IsSetAuxiliaryDataLocation() => this.AuxiliaryDataLocation != null;

        /// <summary>
        /// Gets and sets the property TerminologyProperties. 
        /// <para>
        /// The properties of the custom terminology being imported.
        /// </para>
        /// </summary>
        public TerminologyProperties TerminologyProperties { get; set; }

        /// <summary>
        /// Checks to see if the TerminologyProperties property is set.
        /// </summary>
        internal bool IsSetTerminologyProperties() => this.TerminologyProperties != null;
    }
}
