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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains configuration for X12 control numbers used in X12 EDI generation. Control
    /// numbers are used to uniquely identify interchanges, functional groups, and transaction
    /// sets.
    /// </summary>
    public partial class X12ControlNumbers
    {
        private int? _startingFunctionalGroupControlNumber;
        private int? _startingInterchangeControlNumber;
        private int? _startingTransactionSetControlNumber;

        /// <summary>
        /// Gets and sets the property StartingFunctionalGroupControlNumber. 
        /// <para>
        /// Specifies the starting functional group control number (GS06) to use for X12 EDI generation.
        /// This number is incremented for each new functional group. For the GS (functional group)
        /// envelope, Amazon Web Services B2B Data Interchange generates a functional group control
        /// number that is unique to the sender ID, receiver ID, and functional identifier code
        /// combination. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public int? StartingFunctionalGroupControlNumber
        {
            get { return this._startingFunctionalGroupControlNumber; }
            set { this._startingFunctionalGroupControlNumber = value; }
        }

        // Check to see if StartingFunctionalGroupControlNumber property is set
        internal bool IsSetStartingFunctionalGroupControlNumber()
        {
            return this._startingFunctionalGroupControlNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingInterchangeControlNumber. 
        /// <para>
        /// Specifies the starting interchange control number (ISA13) to use for X12 EDI generation.
        /// This number is incremented for each new interchange. For the ISA (interchange) envelope,
        /// Amazon Web Services B2B Data Interchange generates an interchange control number that
        /// is unique for the ISA05 and ISA06 (sender) &amp; ISA07 and ISA08 (receiver) combination.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public int? StartingInterchangeControlNumber
        {
            get { return this._startingInterchangeControlNumber; }
            set { this._startingInterchangeControlNumber = value; }
        }

        // Check to see if StartingInterchangeControlNumber property is set
        internal bool IsSetStartingInterchangeControlNumber()
        {
            return this._startingInterchangeControlNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartingTransactionSetControlNumber. 
        /// <para>
        /// Specifies the starting transaction set control number (ST02) to use for X12 EDI generation.
        /// This number is incremented for each new transaction set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public int? StartingTransactionSetControlNumber
        {
            get { return this._startingTransactionSetControlNumber; }
            set { this._startingTransactionSetControlNumber = value; }
        }

        // Check to see if StartingTransactionSetControlNumber property is set
        internal bool IsSetStartingTransactionSetControlNumber()
        {
            return this._startingTransactionSetControlNumber.HasValue; 
        }

    }
}