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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a constraint.
    /// </summary>
    public partial class ConstraintDetail
    {
        /// <summary>
        /// Gets and sets the property ConstraintId. 
        /// <para>
        /// The identifier of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ConstraintId { get; set; }

        /// <summary>
        /// Checks to see if the ConstraintId property is set.
        /// </summary>
        internal bool IsSetConstraintId() => this.ConstraintId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the constraint.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The identifier of the portfolio the product resides in. The constraint applies only
        /// to the instance of the product that lives within this portfolio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioId property is set.
        /// </summary>
        internal bool IsSetPortfolioId() => this.PortfolioId != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The identifier of the product the constraint applies to. Note that a constraint applies
        /// to a specific instance of a product within a certain portfolio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

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
        [AWSProperty(Min = 1, Max = 1024)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
