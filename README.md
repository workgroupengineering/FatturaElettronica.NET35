# Fattura Elettronica per .NET **(Unofficial)**

[![Build Status](https://dev.azure.com/workgroupengineering/workgroupengineering/_apis/build/status/workgroupengineering.FatturaElettronica.NET?branchName=net_35)](https://dev.azure.com/workgroupengineering/workgroupengineering/_build/latest?definitionId=2&branchName=net_35)

Questa è una versione non ufficiale, la versione ufficiale si trova **[qui](https://github.com/FatturaElettronica/FatturaElettronica.NET)**.

La differenze rispetto alla build ufficiale sono:

- Aggiunto il supporto al .NET Framework 3.5
- Rimosso il supporto a .NET Standard v1.1.

Il motivo che ci ha spinto alla creazione di questa fork, e perché abbiamo la necessità di mantenere un vecchio software legato ad una libreria che non è compatibile con versioni del .NET Framework superiori alla 3.5. Prima di procedere a questo fork abbiamo creato un **[PR](https://github.com/FatturaElettronica/FatturaElettronica.Core/pull/9)** che introduceva il supporto al .NET Framework 3.5, ma per comprensibili motivi lo sviluppatore non ha voluto integrarla. Avremmo potuto scegliere di svilupparla privatamente, ma nello spirito dell'open source abbiamo deciso di condividerla con tutti.
Vi preghiamo si supportare il progetto **[originale](https://github.com/FatturaElettronica/FatturaElettronica.NET)** perché senza di esso questa fork non avrebbe avuto vita.


## Status della verisone ufficiale

[![Build Status](https://dev.azure.com/FatturaElettronicaNET/FatturaElettronica/_apis/build/status/FatturaElettronica.FatturaElettronica.NET?branchName=master)](https://dev.azure.com/FatturaElettronicaNET/FatturaElettronica/_build/latest?definitionId=1&branchName=master) [![Dependabot Status](https://api.dependabot.com/badges/status?host=github&repo=FatturaElettronica/FatturaElettronica.NET)](https://dependabot.com) [![NuGet version](https://badge.fury.io/nu/FatturaElettronica.svg)](https://badge.fury.io/nu/FatturaElettronica)

## Caratteristiche della verisone ufficiale

- Lettura e scrittura nel formato XML conforme alle [specifiche tecniche ufficiali][pa].
- Convalida offline in osservanza alle specifiche tecniche.
- Fatture elettroniche ordinarie.
- Fatture elettroniche semplificate.
- De/serializzazione JSON.
- Compatibile con [NET Standard v1.1][netstandard].

## Installazione

FatturaElettronica è su [NuGet][nuget].

Dalla command line, con .NET Core:

```Shell
    dotnet add package FatturaElettronica
```

Dalla Package Console, in Visual Studio:

```PowerShell
    PM> Install-Package FatturaElettronica
```

Oppure usare il comando equivalente nella UI di Visual Studio.

## Licenza

FatturaElettronica è un progetto open source di [Nicola Iarocci][ni] e [Gestionali Amica][ga] rilasciato sotto licenza [BSD][bsd].
Artwork by [Kalamun][rp].

### Sponsorship

Se usi FatturaElettronica.NET o qualcun altro dei miei progetti in un
prodotto che genera profitto, buon senso vorrebbe che tu sponsorizzassi la
mia attività open source. Contribuiresti a far sì che il progetto su cui si
basa il tuo prodotto rimanga sano, attivo, e mantenuto nel tempo. Avresti
inoltre, se lo desideri, un premio in visibilità per te o la tua azienda.
Ogni singola sottoscrizione ha un impatto significante.

Scopri come puoi partecipare sulla mia pagina [GitHub Sponsors][ghs]

## Documentazione

- [Sito web](https://fatturaelettronicaopensource.org/)

[pa]: https://www.agenziaentrate.gov.it/wps/content/Nsilib/Nsi/Schede/Comunicazioni/Fatture+e+corrispettivi/Fatture+e+corrispettivi+ST/ST+invio+di+fatturazione+elettronica/?page=ivacomimp
[bsd]: http://github.com/FatturaElettronica/FatturaElettronica.NET/blob/master/LICENSE.txt
[ga]: http://gestionaleamica.com
[ni]: https://nicolaiarocci.com
[nuget]: https://www.nuget.org/packages/FatturaElettronica/
[netstandard]: https://github.com/dotnet/standard/blob/master/docs/versions/netstandard1.1.md
[rp]: http://www.kalamun.org/
[ghs]: https://github.com/sponsors/nicolaiarocci
