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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Translate.Model
{
    /// <summary>
    /// This is the response object from the GetTerminology operation.
    /// </summary>
    public partial class GetTerminologyResponse : AmazonWebServiceResponse
    {
        private TerminologyDataLocation _auxiliaryDataLocation;
        private TerminologyDataLocation _terminologyDataLocation;
        private TerminologyProperties _terminologyProperties;

        /// <summary>
        /// Gets and sets the property AuxiliaryDataLocation. 
        /// <para>
        /// The Amazon S3 location of a file that provides any errors or warnings that were produced
        /// by your input file. This file was created when Amazon Translate attempted to create
        /// a terminology resource. The location is returned as a presigned URL to that has a
        /// 30-minute expiration.
        /// </para>
        /// </summary>
        public TerminologyDataLocation AuxiliaryDataLocation
        {
            get { return this._auxiliaryDataLocation; }
            set { this._auxiliaryDataLocation = value; }
        }

        // Check to see if AuxiliaryDataLocation property is set
        internal bool IsSetAuxiliaryDataLocation()
        {
            return this._auxiliaryDataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TerminologyDataLocation. 
        /// <para>
        /// The Amazon S3 location of the most recent custom terminology input file that was successfully
        /// imported into Amazon Translate. The location is returned as a presigned URL that has
        /// a 30-minute expiration.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon Translate doesn't scan all input files for the risk of CSV injection attacks.
        /// 
        /// </para>
        ///  
        /// <para>
        /// CSV injection occurs when a .csv or .tsv file is altered so that a record contains
        /// malicious code. The record begins with a special character, such as =, +, -, or @.
        /// When the file is opened in a spreadsheet program, the program might interpret the
        /// record as a formula and run the code within it.
        /// </para>
        ///  
        /// <para>
        /// Before you download an input file from Amazon S3, ensure that you recognize the file
        /// and trust its creator.
        /// </para>
        ///  </important>
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