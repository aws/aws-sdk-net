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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Dataset reference.
    /// </summary>
    public partial class DataSetReference
    {
        private string _dataSetArn;
        private string _dataSetPlaceholder;

        /// <summary>
        /// Gets and sets the property DataSetArn. 
        /// <para>
        /// Dataset Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetArn
        {
            get { return this._dataSetArn; }
            set { this._dataSetArn = value; }
        }

        // Check to see if DataSetArn property is set
        internal bool IsSetDataSetArn()
        {
            return this._dataSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetPlaceholder. 
        /// <para>
        /// Dataset placeholder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetPlaceholder
        {
            get { return this._dataSetPlaceholder; }
            set { this._dataSetPlaceholder = value; }
        }

        // Check to see if DataSetPlaceholder property is set
        internal bool IsSetDataSetPlaceholder()
        {
            return this._dataSetPlaceholder != null;
        }

    }
}