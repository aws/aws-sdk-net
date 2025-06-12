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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The request failed because one or more input parameters don't satisfy their constraint
    /// requirements. The output is provided as a list of fields and a reason for each field
    /// that isn't valid.
    /// 
    ///  
    /// <para>
    /// The possible reasons include the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>UnrecognizedEntityType</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy includes an entity type that isn't found in the schema.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>UnrecognizedActionId</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy includes an action id that isn't found in the schema.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>InvalidActionApplication</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy includes an action that, according to the schema, doesn't support the specified
    /// principal and resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>UnexpectedType</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy included an operand that isn't a valid type for the specified operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>IncompatibleTypes</b> 
    /// </para>
    ///  
    /// <para>
    /// The types of elements included in a <c>set</c>, or the types of expressions used in
    /// an <c>if...then...else</c> clause aren't compatible in this context.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>MissingAttribute</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy attempts to access a record or entity attribute that isn't specified in
    /// the schema. Test for the existence of the attribute first before attempting to access
    /// its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
    /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>UnsafeOptionalAttributeAccess</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy attempts to access a record or entity attribute that is optional and isn't
    /// guaranteed to be present. Test for the existence of the attribute first before attempting
    /// to access its value. For more information, see the <a href="https://docs.cedarpolicy.com/policies/syntax-operators.html#has-presence-of-attribute-test">has
    /// (presence of attribute test) operator</a> in the <i>Cedar Policy Language Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ImpossiblePolicy</b> 
    /// </para>
    ///  
    /// <para>
    /// Cedar has determined that a policy condition always evaluates to false. If the policy
    /// is always false, it can never apply to any query, and so it can never affect an authorization
    /// decision.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>WrongNumberArguments</b> 
    /// </para>
    ///  
    /// <para>
    /// The policy references an extension type with the wrong number of arguments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FunctionArgumentValidationError</b> 
    /// </para>
    ///  
    /// <para>
    /// Cedar couldn't parse the argument passed to an extension type. For example, a string
    /// that is to be parsed as an IPv4 address can contain only digits and the period character.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ValidationException : AmazonVerifiedPermissionsException
    {
        private List<ValidationExceptionField> _fieldList = AWSConfigs.InitializeCollections ? new List<ValidationExceptionField>() : null;

        /// <summary>
        /// Constructs a new ValidationException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ValidationException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ValidationException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        /// <param name="innerException"></param>
        public ValidationException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ValidationException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ValidationException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ValidationException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ValidationException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.FieldList = (List<ValidationExceptionField>)info.GetValue("FieldList", typeof(List<ValidationExceptionField>));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("FieldList", this.FieldList);
        }
#endif

        /// <summary>
        /// Gets and sets the property FieldList. 
        /// <para>
        /// The list of fields that aren't valid.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidationExceptionField> FieldList
        {
            get { return this._fieldList; }
            set { this._fieldList = value; }
        }

        // Check to see if FieldList property is set
        internal bool IsSetFieldList()
        {
            return this._fieldList != null && (this._fieldList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}