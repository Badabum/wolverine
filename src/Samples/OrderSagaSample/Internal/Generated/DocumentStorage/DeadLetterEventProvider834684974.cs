// <auto-generated/>
#pragma warning disable
using Marten.Events.Daemon;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertDeadLetterEventOperation834684974
    public class UpsertDeadLetterEventOperation834684974 : Marten.Internal.Operations.StorageOperation<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Events.Daemon.DeadLetterEvent _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertDeadLetterEventOperation834684974(Marten.Events.Daemon.DeadLetterEvent document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select orders.mt_upsert_deadletterevent(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpsertDeadLetterEventOperation834684974
    
    
    // START: InsertDeadLetterEventOperation834684974
    public class InsertDeadLetterEventOperation834684974 : Marten.Internal.Operations.StorageOperation<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Events.Daemon.DeadLetterEvent _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertDeadLetterEventOperation834684974(Marten.Events.Daemon.DeadLetterEvent document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select orders.mt_insert_deadletterevent(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: InsertDeadLetterEventOperation834684974
    
    
    // START: UpdateDeadLetterEventOperation834684974
    public class UpdateDeadLetterEventOperation834684974 : Marten.Internal.Operations.StorageOperation<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Events.Daemon.DeadLetterEvent _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateDeadLetterEventOperation834684974(Marten.Events.Daemon.DeadLetterEvent document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select orders.mt_update_deadletterevent(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }

    }

    // END: UpdateDeadLetterEventOperation834684974
    
    
    // START: QueryOnlyDeadLetterEventSelector834684974
    public class QueryOnlyDeadLetterEventSelector834684974 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<Marten.Events.Daemon.DeadLetterEvent>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyDeadLetterEventSelector834684974(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Events.Daemon.DeadLetterEvent Resolve(System.Data.Common.DbDataReader reader)
        {

            Marten.Events.Daemon.DeadLetterEvent document;
            document = _serializer.FromJson<Marten.Events.Daemon.DeadLetterEvent>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Events.Daemon.DeadLetterEvent> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            Marten.Events.Daemon.DeadLetterEvent document;
            document = await _serializer.FromJsonAsync<Marten.Events.Daemon.DeadLetterEvent>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyDeadLetterEventSelector834684974
    
    
    // START: LightweightDeadLetterEventSelector834684974
    public class LightweightDeadLetterEventSelector834684974 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<Marten.Events.Daemon.DeadLetterEvent, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Events.Daemon.DeadLetterEvent>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightDeadLetterEventSelector834684974(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Events.Daemon.DeadLetterEvent Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            Marten.Events.Daemon.DeadLetterEvent document;
            document = _serializer.FromJson<Marten.Events.Daemon.DeadLetterEvent>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Events.Daemon.DeadLetterEvent> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            Marten.Events.Daemon.DeadLetterEvent document;
            document = await _serializer.FromJsonAsync<Marten.Events.Daemon.DeadLetterEvent>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightDeadLetterEventSelector834684974
    
    
    // START: IdentityMapDeadLetterEventSelector834684974
    public class IdentityMapDeadLetterEventSelector834684974 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<Marten.Events.Daemon.DeadLetterEvent, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Events.Daemon.DeadLetterEvent>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapDeadLetterEventSelector834684974(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Events.Daemon.DeadLetterEvent Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Events.Daemon.DeadLetterEvent document;
            document = _serializer.FromJson<Marten.Events.Daemon.DeadLetterEvent>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Events.Daemon.DeadLetterEvent> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Events.Daemon.DeadLetterEvent document;
            document = await _serializer.FromJsonAsync<Marten.Events.Daemon.DeadLetterEvent>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapDeadLetterEventSelector834684974
    
    
    // START: DirtyTrackingDeadLetterEventSelector834684974
    public class DirtyTrackingDeadLetterEventSelector834684974 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<Marten.Events.Daemon.DeadLetterEvent, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Events.Daemon.DeadLetterEvent>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingDeadLetterEventSelector834684974(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Events.Daemon.DeadLetterEvent Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Events.Daemon.DeadLetterEvent document;
            document = _serializer.FromJson<Marten.Events.Daemon.DeadLetterEvent>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Events.Daemon.DeadLetterEvent> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Events.Daemon.DeadLetterEvent document;
            document = await _serializer.FromJsonAsync<Marten.Events.Daemon.DeadLetterEvent>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingDeadLetterEventSelector834684974
    
    
    // START: QueryOnlyDeadLetterEventDocumentStorage834684974
    public class QueryOnlyDeadLetterEventDocumentStorage834684974 : Marten.Internal.Storage.QueryOnlyDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyDeadLetterEventDocumentStorage834684974(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Events.Daemon.DeadLetterEvent document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Events.Daemon.DeadLetterEvent document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyDeadLetterEventSelector834684974(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyDeadLetterEventDocumentStorage834684974
    
    
    // START: LightweightDeadLetterEventDocumentStorage834684974
    public class LightweightDeadLetterEventDocumentStorage834684974 : Marten.Internal.Storage.LightweightDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightDeadLetterEventDocumentStorage834684974(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Events.Daemon.DeadLetterEvent document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Events.Daemon.DeadLetterEvent document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightDeadLetterEventSelector834684974(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightDeadLetterEventDocumentStorage834684974
    
    
    // START: IdentityMapDeadLetterEventDocumentStorage834684974
    public class IdentityMapDeadLetterEventDocumentStorage834684974 : Marten.Internal.Storage.IdentityMapDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapDeadLetterEventDocumentStorage834684974(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Events.Daemon.DeadLetterEvent document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Events.Daemon.DeadLetterEvent document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapDeadLetterEventSelector834684974(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapDeadLetterEventDocumentStorage834684974
    
    
    // START: DirtyTrackingDeadLetterEventDocumentStorage834684974
    public class DirtyTrackingDeadLetterEventDocumentStorage834684974 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingDeadLetterEventDocumentStorage834684974(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Events.Daemon.DeadLetterEvent document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDeadLetterEventOperation834684974
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Events.Daemon.DeadLetterEvent, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Events.Daemon.DeadLetterEvent document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Events.Daemon.DeadLetterEvent document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingDeadLetterEventSelector834684974(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingDeadLetterEventDocumentStorage834684974
    
    
    // START: DeadLetterEventBulkLoader834684974
    public class DeadLetterEventBulkLoader834684974 : Marten.Internal.CodeGeneration.BulkLoader<Marten.Events.Daemon.DeadLetterEvent, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid> _storage;

        public DeadLetterEventBulkLoader834684974(Marten.Internal.Storage.IDocumentStorage<Marten.Events.Daemon.DeadLetterEvent, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY orders.mt_doc_deadletterevent(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_deadletterevent_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into orders.mt_doc_deadletterevent (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_deadletterevent_temp.\"id\", mt_doc_deadletterevent_temp.\"data\", mt_doc_deadletterevent_temp.\"mt_version\", mt_doc_deadletterevent_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_deadletterevent_temp left join orders.mt_doc_deadletterevent on mt_doc_deadletterevent_temp.id = orders.mt_doc_deadletterevent.id where orders.mt_doc_deadletterevent.id is null)";

        public const string OVERWRITE_SQL = "update orders.mt_doc_deadletterevent target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_deadletterevent_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_deadletterevent_temp as select * from orders.mt_doc_deadletterevent limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, Marten.Events.Daemon.DeadLetterEvent document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, Marten.Events.Daemon.DeadLetterEvent document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: DeadLetterEventBulkLoader834684974
    
    
    // START: DeadLetterEventProvider834684974
    public class DeadLetterEventProvider834684974 : Marten.Internal.Storage.DocumentProvider<Marten.Events.Daemon.DeadLetterEvent>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DeadLetterEventProvider834684974(Marten.Schema.DocumentMapping mapping) : base(new DeadLetterEventBulkLoader834684974(new QueryOnlyDeadLetterEventDocumentStorage834684974(mapping)), new QueryOnlyDeadLetterEventDocumentStorage834684974(mapping), new LightweightDeadLetterEventDocumentStorage834684974(mapping), new IdentityMapDeadLetterEventDocumentStorage834684974(mapping), new DirtyTrackingDeadLetterEventDocumentStorage834684974(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: DeadLetterEventProvider834684974
    
    
}

