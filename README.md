"# apbd-cw1-git-s33169" 


merge nie byl FF, bo fast-forward wymaga, aby jedna z gałęzi była bezpośrednim przodkiem drugiej

    1.Git zrobi fast‑forward, gdy gałąź, do której chcemy włączyć zmiany, nie ma własnych commitów po punkcie rozgałęzienia, czyli historia jest liniowa i wystarczy „przesunąć wskaźnik” do przodu.
    Merge commit powstaje wtedy, gdy obie gałęzie poszły różnymi ścieżkami i mają własne, niezależne commity i wtedy Git musi stworzyć nowy commit łączący te dwie historie.

    2. Merge łączy dwie gałęzie zachowując historię taką, jaka była, a rebase przepisuje historię, ustawiając commity na końcu innej gałęzi, jakby powstały później.

    3. Za pomocą narzędzia Visual Studio Code do rozwiązywania konfliktów podczas merge - zaakceptowalem rozwiązanie z Local repo zamiast Remote.