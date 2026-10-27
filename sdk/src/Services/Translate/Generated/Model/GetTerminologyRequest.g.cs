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
    /// Container for the parameters to the GetTerminology operation. Retrieves a custom terminology.
    /// </summary>
    public partial class GetTerminologyRequest : AmazonTranslateRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom terminology being retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TerminologyDataFormat. 
        /// <para>
        /// The data format of the custom terminology being retrieved.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, Amazon Translate returns a file with the same
        /// format as the file that was imported to create the terminology. 
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter when you retrieve a multi-directional terminology resource,
        /// you must specify the same format as the input file that was imported to create it.
        /// Otherwise, Amazon Translate throws an error.
        /// </para>
        /// </summary>
        public TerminologyDataFormat TerminologyDataFormat { get; set; }

        /// <summary>
        /// Checks to see if the TerminologyDataFormat property is set.
        /// </summary>
        internal bool IsSetTerminologyDataFormat() => this.TerminologyDataFormat != null;
    }
}
