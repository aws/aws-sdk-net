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
    /// The location of the custom terminology data.
    /// </summary>
    public partial class TerminologyDataLocation
    {
        private string _location;
        private string _repositoryType;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon S3 location of the most recent custom terminology input file that was successfully
        /// imported into Amazon Translate. The location is returned as a presigned URL that has
        /// a 30-minute expiration .
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
        [AWSProperty(Required=true, Max=10000)]
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

        /// <summary>
        /// Gets and sets the property RepositoryType. 
        /// <para>
        /// The repository type for the custom terminology data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
        public string RepositoryType
        {
            get { return this._repositoryType; }
            set { this._repositoryType = value; }
        }

        // Check to see if RepositoryType property is set
        internal bool IsSetRepositoryType()
        {
            return this._repositoryType != null;
        }

    }
}