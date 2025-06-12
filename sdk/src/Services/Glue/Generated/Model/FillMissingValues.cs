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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that locates records in the dataset that have missing values
    /// and adds a new field with a value determined by imputation. The input data set is
    /// used to train the machine learning model that determines what the missing value should
    /// be.
    /// </summary>
    public partial class FillMissingValues
    {
        private string _filledPath;
        private string _imputedPath;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property FilledPath. 
        /// <para>
        /// A JSON path to a variable in the data structure for the dataset that is filled.
        /// </para>
        /// </summary>
        public string FilledPath
        {
            get { return this._filledPath; }
            set { this._filledPath = value; }
        }

        // Check to see if FilledPath property is set
        internal bool IsSetFilledPath()
        {
            return this._filledPath != null;
        }

        /// <summary>
        /// Gets and sets the property ImputedPath. 
        /// <para>
        /// A JSON path to a variable in the data structure for the dataset that is imputed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImputedPath
        {
            get { return this._imputedPath; }
            set { this._imputedPath = value; }
        }

        // Check to see if ImputedPath property is set
        internal bool IsSetImputedPath()
        {
            return this._imputedPath != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The data inputs identified by their node names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}