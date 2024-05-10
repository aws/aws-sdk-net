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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a constraint.
    /// </summary>
    public partial class ConstraintDetail
    {
        private string _constraintId;
        private string _description;
        private string _owner;
        private string _portfolioId;
        private string _productId;
        private string _type;

        /// <summary>
        /// Gets and sets the property ConstraintId. 
        /// <para>
        /// The identifier of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ConstraintId
        {
            get { return this._constraintId; }
            set { this._constraintId = value; }
        }

        // Check to see if ConstraintId property is set
        internal bool IsSetConstraintId()
        {
            return this._constraintId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the constraint.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The identifier of the portfolio the product resides in. The constraint applies only
        /// to the instance of the product that lives within this portfolio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PortfolioId
        {
            get { return this._portfolioId; }
            set { this._portfolioId = value; }
        }

        // Check to see if PortfolioId property is set
        internal bool IsSetPortfolioId()
        {
            return this._portfolioId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The identifier of the product the constraint applies to. Note that a constraint applies
        /// to a specific instance of a product within a certain portfolio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of constraint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LAUNCH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOTIFICATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STACKSET
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPLATE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}