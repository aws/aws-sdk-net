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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// This is the response object from the SendCommand operation.
    /// </summary>
    public partial class SendCommandResponse : AmazonWebServiceResponse
    {
        private AbortTransactionResult _abortTransaction;
        private CommitTransactionResult _commitTransaction;
        private EndSessionResult _endSession;
        private ExecuteStatementResult _executeStatement;
        private FetchPageResult _fetchPage;
        private StartSessionResult _startSession;
        private StartTransactionResult _startTransaction;

        /// <summary>
        /// Gets and sets the property AbortTransaction. 
        /// <para>
        /// Contains the details of the aborted transaction.
        /// </para>
        /// </summary>
        public AbortTransactionResult AbortTransaction
        {
            get { return this._abortTransaction; }
            set { this._abortTransaction = value; }
        }

        // Check to see if AbortTransaction property is set
        internal bool IsSetAbortTransaction()
        {
            return this._abortTransaction != null;
        }

        /// <summary>
        /// Gets and sets the property CommitTransaction. 
        /// <para>
        /// Contains the details of the committed transaction.
        /// </para>
        /// </summary>
        public CommitTransactionResult CommitTransaction
        {
            get { return this._commitTransaction; }
            set { this._commitTransaction = value; }
        }

        // Check to see if CommitTransaction property is set
        internal bool IsSetCommitTransaction()
        {
            return this._commitTransaction != null;
        }

        /// <summary>
        /// Gets and sets the property EndSession. 
        /// <para>
        /// Contains the details of the ended session.
        /// </para>
        /// </summary>
        public EndSessionResult EndSession
        {
            get { return this._endSession; }
            set { this._endSession = value; }
        }

        // Check to see if EndSession property is set
        internal bool IsSetEndSession()
        {
            return this._endSession != null;
        }

        /// <summary>
        /// Gets and sets the property ExecuteStatement. 
        /// <para>
        /// Contains the details of the executed statement.
        /// </para>
        /// </summary>
        public ExecuteStatementResult ExecuteStatement
        {
            get { return this._executeStatement; }
            set { this._executeStatement = value; }
        }

        // Check to see if ExecuteStatement property is set
        internal bool IsSetExecuteStatement()
        {
            return this._executeStatement != null;
        }

        /// <summary>
        /// Gets and sets the property FetchPage. 
        /// <para>
        /// Contains the details of the fetched page.
        /// </para>
        /// </summary>
        public FetchPageResult FetchPage
        {
            get { return this._fetchPage; }
            set { this._fetchPage = value; }
        }

        // Check to see if FetchPage property is set
        internal bool IsSetFetchPage()
        {
            return this._fetchPage != null;
        }

        /// <summary>
        /// Gets and sets the property StartSession. 
        /// <para>
        /// Contains the details of the started session that includes a session token. This <c>SessionToken</c>
        /// is required for every subsequent command that is issued during the current session.
        /// </para>
        /// </summary>
        public StartSessionResult StartSession
        {
            get { return this._startSession; }
            set { this._startSession = value; }
        }

        // Check to see if StartSession property is set
        internal bool IsSetStartSession()
        {
            return this._startSession != null;
        }

        /// <summary>
        /// Gets and sets the property StartTransaction. 
        /// <para>
        /// Contains the details of the started transaction.
        /// </para>
        /// </summary>
        public StartTransactionResult StartTransaction
        {
            get { return this._startTransaction; }
            set { this._startTransaction = value; }
        }

        // Check to see if StartTransaction property is set
        internal bool IsSetStartTransaction()
        {
            return this._startTransaction != null;
        }

    }
}