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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains information about an application-specific calculation result.
    /// </summary>
    public partial class CalculationResult
    {
        private string _resultS3Uri;
        private string _resultType;
        private string _stdErrorS3Uri;
        private string _stdOutS3Uri;

        /// <summary>
        /// Gets and sets the property ResultS3Uri. 
        /// <para>
        /// The Amazon S3 location of the folder for the calculation results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ResultS3Uri
        {
            get { return this._resultS3Uri; }
            set { this._resultS3Uri = value; }
        }

        // Check to see if ResultS3Uri property is set
        internal bool IsSetResultS3Uri()
        {
            return this._resultS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The data format of the calculation result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResultType
        {
            get { return this._resultType; }
            set { this._resultType = value; }
        }

        // Check to see if ResultType property is set
        internal bool IsSetResultType()
        {
            return this._resultType != null;
        }

        /// <summary>
        /// Gets and sets the property StdErrorS3Uri. 
        /// <para>
        /// The Amazon S3 location of the <code>stderr</code> error messages file for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string StdErrorS3Uri
        {
            get { return this._stdErrorS3Uri; }
            set { this._stdErrorS3Uri = value; }
        }

        // Check to see if StdErrorS3Uri property is set
        internal bool IsSetStdErrorS3Uri()
        {
            return this._stdErrorS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property StdOutS3Uri. 
        /// <para>
        /// The Amazon S3 location of the <code>stdout</code> file for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string StdOutS3Uri
        {
            get { return this._stdOutS3Uri; }
            set { this._stdOutS3Uri = value; }
        }

        // Check to see if StdOutS3Uri property is set
        internal bool IsSetStdOutS3Uri()
        {
            return this._stdOutS3Uri != null;
        }

    }
}