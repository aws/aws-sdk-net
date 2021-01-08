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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The source analysis of the template.
    /// </summary>
    public partial class TemplateSourceAnalysis
    {
        private string _arn;
        private List<DataSetReference> _dataSetReferences = new List<DataSetReference>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetReferences. 
        /// <para>
        /// A structure containing information about the dataset references used as placeholders
        /// in the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<DataSetReference> DataSetReferences
        {
            get { return this._dataSetReferences; }
            set { this._dataSetReferences = value; }
        }

        // Check to see if DataSetReferences property is set
        internal bool IsSetDataSetReferences()
        {
            return this._dataSetReferences != null && this._dataSetReferences.Count > 0; 
        }

    }
}