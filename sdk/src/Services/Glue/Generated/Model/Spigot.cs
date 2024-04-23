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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that writes samples of the data to an Amazon S3 bucket.
    /// </summary>
    public partial class Spigot
    {
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _path;
        private double? _prob;
        private int? _topk;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The data inputs identified by their node names.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A path in Amazon S3 where the transform will write a subset of records from the dataset
        /// to a JSON file in an Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Prob. 
        /// <para>
        /// The probability (a decimal value with a maximum value of 1) of picking any given record.
        /// A value of 1 indicates that each row read from the dataset should be included in the
        /// sample output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double Prob
        {
            get { return this._prob.GetValueOrDefault(); }
            set { this._prob = value; }
        }

        // Check to see if Prob property is set
        internal bool IsSetProb()
        {
            return this._prob.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Topk. 
        /// <para>
        /// Specifies a number of records to write starting from the beginning of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Topk
        {
            get { return this._topk.GetValueOrDefault(); }
            set { this._topk = value; }
        }

        // Check to see if Topk property is set
        internal bool IsSetTopk()
        {
            return this._topk.HasValue; 
        }

    }
}