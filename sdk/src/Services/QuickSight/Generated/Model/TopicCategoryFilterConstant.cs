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
    /// A constant used in a category filter.
    /// </summary>
    public partial class TopicCategoryFilterConstant
    {
        private CollectiveConstant _collectiveConstant;
        private ConstantType _constantType;
        private string _singularConstant;

        /// <summary>
        /// Gets and sets the property CollectiveConstant. 
        /// <para>
        /// A collective constant used in a category filter. This element is used to specify a
        /// list of values for the constant.
        /// </para>
        /// </summary>
        public CollectiveConstant CollectiveConstant
        {
            get { return this._collectiveConstant; }
            set { this._collectiveConstant = value; }
        }

        // Check to see if CollectiveConstant property is set
        internal bool IsSetCollectiveConstant()
        {
            return this._collectiveConstant != null;
        }

        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The type of category filter constant. This element is used to specify whether a constant
        /// is a singular or collective. Valid values are <c>SINGULAR</c> and <c>COLLECTIVE</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType
        {
            get { return this._constantType; }
            set { this._constantType = value; }
        }

        // Check to see if ConstantType property is set
        internal bool IsSetConstantType()
        {
            return this._constantType != null;
        }

        /// <summary>
        /// Gets and sets the property SingularConstant. 
        /// <para>
        /// A singular constant used in a category filter. This element is used to specify a single
        /// value for the constant.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string SingularConstant
        {
            get { return this._singularConstant; }
            set { this._singularConstant = value; }
        }

        // Check to see if SingularConstant property is set
        internal bool IsSetSingularConstant()
        {
            return this._singularConstant != null;
        }

    }
}